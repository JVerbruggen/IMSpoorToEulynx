﻿using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.sig;
using Services.DependencyInjection;
using Services.Managers.Assets;
using Services.Service;
using Services.Service.PathFinding;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Node = Microsoft.Msagl.Drawing.Node;
using Edge = Microsoft.Msagl.Drawing.Edge;

namespace FormsApp
{
    public partial class TopologyView : Form
    {
        private EulynxDataPrep eulynx = null;
        private Graph graph;
        private GViewer viewer;
        private PathFinderService PathFinderService;
        private DestinationFinderService DestinationFinderService;
        private NetEntityLocator netEntityLocator;

        private Path paintedPath;

        public TopologyView()
        {
            Initialize();
        }

        public TopologyView(EulynxDataPrep eulynx) : this()
        {
            this.eulynx = eulynx;

            InitMsagl(this.eulynx);
            //InitDrawing(this.eulynx);
        }

        private void InitDrawing(EulynxDataPrep eulynx)
        {
            using (var g = this.CreateGraphics())
            {
                using (Pen pen = new Pen(System.Drawing.Color.Black, 5))
                {
                    var pt1 = new System.Drawing.Point(0, 0);
                    var pt2 = new System.Drawing.Point(100, 100);
                    g.DrawLine(pen, pt1, pt2);
                }
            }
        }

        private void InitMsagl(EulynxDataPrep eulynx)
        {
            this.viewer = new GViewer();
            this.graph = new Graph("MyGraph");

            var rtmEntities = eulynx?.ownsRtmEntities;
            var trackTopo = rtmEntities?.usesTrackTopology;
            if (rtmEntities != null && trackTopo != null)
            {
                comboBox_pathFindStart.Items.AddRange(trackTopo.usesPositioningNetElement.Select(n => n.id).ToArray());
                fillComboBoxPathFindEnd(trackTopo.usesPositioningNetElement.Select(n => n.id).ToArray());

                IEnumerable<PositionedRelation> relations = trackTopo.usesPositionedRelation;
                foreach (PositionedRelation relation in relations)
                {
                    string refA = relation.elementA.@ref;
                    string refB = relation.elementB.@ref;

                    if (refA == null || refB == null) continue;

                    Edge e = this.graph.AddEdge(refA, refB);

                    e.Attr.ArrowheadAtSource = relation.positionOnA == Usage.start ? ArrowStyle.Diamond : ArrowStyle.None;
                    e.Attr.ArrowheadAtTarget = relation.positionOnB == Usage.start ? ArrowStyle.Diamond : ArrowStyle.None;
                }
            }

            this.viewer.Graph = this.graph;
            viewer.Click += ViewerNodeClickEvent;

            this.SuspendLayout();
            this.viewer.Dock = DockStyle.Fill;
            this.groupBox_drawing.Controls.Add(this.viewer);
            this.ResumeLayout();
        }

        private void fillComboBoxPathFindEnd(object[] items)
        {
            comboBox_pathFindEnd.Items.Clear();
            comboBox_pathFindEnd.Items.AddRange(items);
        }

        public void ViewerNodeClickEvent(object sender, EventArgs e)
        {
            GViewer viewer = sender as GViewer;
            if(viewer.SelectedObject is Node)
            {
                Node node = viewer.SelectedObject as Node;
                fillPathFindPath(node.LabelText);
            }
        }

        private void fillPathFindPath(string label)
        {
            if (!eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement.Any(item => item.id == label)) return;

            if(comboBox_pathFindStart.Text == "")
            {
                comboBox_pathFindStart.SelectedItem = label;
            }else if(comboBox_pathFindEnd.Text == "")
            {
                comboBox_pathFindEnd.SelectedItem = label;
            }
            else
            {
                comboBox_pathFindStart.SelectedItem = label;
                comboBox_pathFindEnd.SelectedItem = null;
                comboBox_pathFindEnd.Text = null;
            }
        }

        private void Initialize()
        {
            this.PathFinderService = InstanceManager.Singleton<PathFinderService>().GetInstance();
            this.netEntityLocator = InstanceManager.Singleton<NetEntityLocator>().GetInstance();
            this.DestinationFinderService = InstanceManager.Singleton<DestinationFinderService>().GetInstance();
            InitializeComponent();
        }

        private void paintFoundPath(IEnumerable<PositioningNetElement> path, IEnumerable<PositioningNetElement> allElements)
        {
            this.paintedPath = new Path(path);

            foreach (PositioningNetElement pathElement in allElements)
            {
                if (this.graph.FindNode(pathElement.id) == null) continue;

                if (path.Contains(pathElement))
                {
                    this.graph.FindNode(pathElement.id).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else
                {
                    this.graph.FindNode(pathElement.id).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button_findPathSubmit_Click(object sender, EventArgs e)
        {
            findPath();
            showDetails();
        }

        private void button_possiblePaths_Click(object sender, EventArgs e)
        {
            fillPossiblePaths();
        }

        private void findPath()
        {
            string uuidStart = comboBox_pathFindStart.SelectedItem?.ToString();
            string uuidEnd = comboBox_pathFindEnd.SelectedItem?.ToString();

            if (uuidStart != null && uuidEnd != null)
            {
                IEnumerable<PositioningNetElement> shortestPath = FindShortestPath(this.eulynx, uuidStart, uuidEnd);
                IEnumerable<PositioningNetElement> allNetElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

                paintFoundPath(shortestPath, allNetElements);

                if (shortestPath.Count() == 0)
                {
                    listbox_show(new[] { "No paths found" });
                }
                else
                {
                    listbox_show(new[] { "" });
                }
            }
        }

        private void fillPossiblePaths()
        {
            string uuidStart = comboBox_pathFindStart.SelectedItem?.ToString();

            if (uuidStart != null)
            {
                IEnumerable<PositioningNetElement> foundDestinations = FindPossibleDestinations(this.eulynx, uuidStart, checkBox_includePassedElements.Checked);
                int fdcount = foundDestinations.Count();

                if (fdcount > 0)
                {
                    comboBox_pathFindEnd.Items.Clear();
                    comboBox_pathFindEnd.Items.AddRange(foundDestinations.Select(d => d.id).ToArray());
                    comboBox_pathFindEnd.SelectedItem = null;
                    comboBox_pathFindEnd.Text = null;

                    List<string> contents = new List<string>();
                    contents.AddRange(new[]
                    {
                        "Found destinations: " + fdcount,
                        "Including passed elements: " + checkBox_includePassedElements.Checked,
                        "Destinations:"
                    });
                    foreach (var el in foundDestinations)
                    {
                        contents.Add("- " + el.id);
                    }

                    listbox_show(contents.ToArray());
                }
                else
                {
                    listbox_show(new[] { "Found no destinations" });
                }
            }
        }

        private IEnumerable<PositioningNetElement> FindPossibleDestinations(EulynxDataPrep eulynx, string uuidStart, bool includePassed)
        {
            IEnumerable<PositioningNetElement> foundDestinations = DestinationFinderService.FindPossibleDestinations(eulynx, uuidStart, includePassed);

            return foundDestinations;
        }

        private IEnumerable<PositioningNetElement> FindShortestPath(EulynxDataPrep eulynx, string uuidStart, string uuidEnd)
        {
            IEnumerable<PositioningNetElement> shortestPath = PathFinderService.FindShortestPath(eulynx, uuidStart, uuidEnd);

            return shortestPath;
        }

        private void listbox_show(IEnumerable<object> objects)
        {
            listBox_content.Items.Clear();

            if(objects != null)
            {
                listBox_content.Items.AddRange(objects.ToArray());
            }
        }

        private void button_netEntities_Click(object sender, EventArgs e)
        {
            showNetEntities();
        }

        private void groupBox_drawing_Paint(object sender, PaintEventArgs e)
        {
            //var g = e.Graphics;
            //using(Brush brush = new SolidBrush(System.Drawing.Color.Black))
            //{
            //    using (Pen pen = new Pen(brush, 5))
            //    {
            //        var pt1 = new System.Drawing.Point(0, 0);
            //        var pt2 = new System.Drawing.Point(100, 100);
            //        g.DrawLine(pen, pt1, pt2);
            //    }
            //}
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            resetInfobox();
        }

        private void resetInfobox()
        {
            var trackTopo = this.eulynx?.ownsRtmEntities?.usesTrackTopology;
            if (trackTopo == null) return;

            fillComboBoxPathFindEnd(trackTopo.usesPositioningNetElement.Select(n => n.id).ToArray());

            comboBox_pathFindStart.SelectedItem = null;
            comboBox_pathFindStart.Text = null;
            comboBox_pathFindEnd.SelectedItem = null;
            comboBox_pathFindEnd.Text = null;

            IEnumerable<PositioningNetElement> allNetElements = this.eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;
            paintFoundPath(new PositioningNetElement[] { }, allNetElements);

            listbox_show(new[] { "" });
        }

        private void showNetEntities()
        {
            if (this.paintedPath == null) return;

            TrackAssetManager trackAssetManager = InstanceManager.Singleton<TrackAssetManager>().GetInstance();
            var t = trackAssetManager.GetTrackAssets(eulynx);

            IEnumerable<TrackAsset> pathTrackAssets = trackAssetManager.GetTrackAssets(eulynx, this.paintedPath.elements);

            listbox_show(pathTrackAssets);
        }

        private void showDetails()
        {
            if (this.paintedPath == null || this.paintedPath.elements.Count() == 0) return;

            List<string> contents = new List<string>();

            int steps = this.paintedPath.GetSteps();

            contents.AddRange(new[]{
                "Start: " + this.paintedPath.elements.FirstOrDefault().id,
                "End: " + this.paintedPath.elements.LastOrDefault().id,
                "Distance: " + steps + " step" + (steps == 1 ? "" : "s"),
                "Path: "});

            foreach (var el in this.paintedPath.elements)
            {
                contents.Add("- " + el.id);
            }

            listbox_show(contents.ToArray());
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            showDetails();
        }
    }
}
