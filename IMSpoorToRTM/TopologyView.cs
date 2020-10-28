using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.TopoModels.Eulynx.NetEntity;
using Services.DependencyInjection;
using Services.Managers.Assets;
using Services.Managers.Topology;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class TopologyView : Form
    {
        private Eulynx eulynx = null;
        private Graph graph;
        private GViewer viewer;
        private PathFinderService PathFinderService;
        private NetEntityLocator netEntityLocator;

        private PositioningNetElement[] paintedPath;

        public TopologyView()
        {
            Initialize();
        }

        public TopologyView(Eulynx eulynx) : this()
        {
            this.eulynx = eulynx;

            this.viewer = new GViewer();
            this.graph = new Graph("MyGraph");

            var rtmEntities = eulynx?.ownsRtmEntities;
            var trackTopo = rtmEntities?.usesTrackTopology;

            if (rtmEntities != null && trackTopo != null)
            {
                foreach (PositioningNetElement netElement in trackTopo.usesPositioningNetElement)
                {
                    comboBox_pathFindStart.Items.Add(netElement.uuid);
                    comboBox_pathFindEnd.Items.Add(netElement.uuid);
                }

                PositionedRelation[] relations = trackTopo.usesPositionedRelation;
                foreach (PositionedRelation relation in relations)
                {
                    string refA = relation.elementA.@ref;
                    string refB = relation.elementB.@ref;

                    if (refA == null || refB == null) continue;

                    this.graph.AddEdge(refA, refB);
                }
            }

            this.viewer.Graph = this.graph;
            viewer.Click += ViewerNodeClickEvent;

            this.SuspendLayout();
            this.viewer.Dock = DockStyle.Fill;
            this.groupBox_drawing.Controls.Add(this.viewer);
            this.ResumeLayout();
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
            if (!eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement.Any(item => item.uuid == label)) return;

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
            }
        }

        private void Initialize()
        {
            this.PathFinderService = InstanceManager.Singleton<PathFinderService>().GetInstance();
            this.netEntityLocator = InstanceManager.Singleton<NetEntityLocator>().GetInstance();
            InitializeComponent();
        }

        private void paintFoundPath(PositioningNetElement[] path, PositioningNetElement[] allElements)
        {
            this.paintedPath = path;

            foreach (PositioningNetElement pathElement in allElements)
            {
                if (path.Contains(pathElement))
                {
                    this.graph.FindNode(pathElement.uuid).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                else
                {
                    this.graph.FindNode(pathElement.uuid).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
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
            string uuidStart = comboBox_pathFindStart.SelectedItem?.ToString();
            string uuidEnd = comboBox_pathFindEnd.SelectedItem?.ToString();

            if(uuidStart != null && uuidEnd != null)
            {
                FindShortestPath(this.eulynx, uuidStart, uuidEnd);
            }
        }

        private void FindShortestPath(Eulynx eulynx, string uuidStart, string uuidEnd)
        {
            PositioningNetElement[] shortestPath = PathFinderService.FindShortestPath(eulynx, uuidStart, uuidEnd);
            PositioningNetElement[] allNetElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

            paintFoundPath(shortestPath, allNetElements);
        }

        private void button_netEntities_Click(object sender, EventArgs e)
        {
            if (this.paintedPath == null) return;
            var allPSCoords = eulynx.ownsRtmEntities.usesPositioningSystemCoordinate;

            TrackAssetManager trackAssetManager = InstanceManager.Singleton<TrackAssetManager>().GetInstance();

            //BaseLocation[] allLocations = this.eulynx.ownsRtmEntities.usesSpotLocation.Where(sl => sl is SpotLocationCoordinate).Cast<SpotLocationCoordinate>().ToArray();
            //LocatedNetEntity[] allNetEntities = this.eulynx.ownsRtmEntities.ownsSignal;
            TrackAsset[] pathTrackAssets = trackAssetManager.GetTrackAssets(eulynx, this.paintedPath);

            //LocatedNetEntity[] netEntities = netEntityLocator.GetAssetsOnPath(this.paintedPath, allLocations, allNetEntities);

            listBox_content.Items.Clear(); 
            //listBox_content.Items.AddRange(netEntities);
            listBox_content.Items.AddRange(pathTrackAssets);
        }
    }
}
