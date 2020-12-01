using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Services.DependencyInjection;
using Services.Managers.Assets;
using Services.Service;
using Services.Service.PathFinding;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class TopologyView : Form
    {
        private Eulynx eulynx = null;
        private Graph graph;
        private GViewer viewer;
        private PathFinderService PathFinderService;
        private DestinationFinderService DestinationFinderService;
        private NetEntityLocator netEntityLocator;

        private PositioningNetElement[] paintedPath;

        public TopologyView()
        {
            Initialize();
        }

        public TopologyView(Eulynx eulynx) : this()
        {
            this.eulynx = eulynx;

            InitMsagl(this.eulynx);
            //InitDrawing(this.eulynx);
        }

        private void InitDrawing(Eulynx eulynx)
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

        private void InitMsagl(Eulynx eulynx)
        {
            this.viewer = new GViewer();
            this.graph = new Graph("MyGraph");

            var rtmEntities = eulynx?.ownsRtmEntities;
            var trackTopo = rtmEntities?.usesTrackTopology;
            if (rtmEntities != null && trackTopo != null)
            {
                comboBox_pathFindStart.Items.AddRange(trackTopo.usesPositioningNetElement.Select(n => n.uuid).ToArray());
                fillComboBoxPathFindEnd(trackTopo.usesPositioningNetElement.Select(n => n.uuid).ToArray());

                PositionedRelation[] relations = trackTopo.usesPositionedRelation;
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

        private void paintFoundPath(PositioningNetElement[] path, PositioningNetElement[] allElements)
        {
            this.paintedPath = path;

            foreach (PositioningNetElement pathElement in allElements)
            {
                if (this.graph.FindNode(pathElement.uuid) == null) continue;

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

            if (uuidStart != null && uuidEnd != null)
            {
                FindShortestPath(this.eulynx, uuidStart, uuidEnd);
            }
        }

        private void button_possiblePaths_Click(object sender, EventArgs e)
        {
            string uuidStart = comboBox_pathFindStart.SelectedItem?.ToString();

            if(uuidStart != null)
            {
                PositioningNetElement[] foundDestinations = FindPossibleDestinations(this.eulynx, uuidStart);

                if(foundDestinations.Length > 0)
                {
                    comboBox_pathFindEnd.Items.Clear();
                    comboBox_pathFindEnd.Items.AddRange(foundDestinations.Select(d => d.uuid).ToArray());
                    comboBox_pathFindEnd.SelectedItem = null;
                    comboBox_pathFindEnd.Text = null;

                    listbox_show(new[] { "Found " + foundDestinations.Length + " destinations" });
                }
                else
                {
                    listbox_show(new[] { "Found no destinations" });
                }
            }
        }

        private PositioningNetElement[] FindPossibleDestinations(Eulynx eulynx, string uuidStart)
        {
            PositioningNetElement[] foundDestinations = DestinationFinderService.FindPossibleDestinations_DeepOnly(eulynx, uuidStart);

            return foundDestinations;
        }

        private void FindShortestPath(Eulynx eulynx, string uuidStart, string uuidEnd)
        {
            PositioningNetElement[] shortestPath = PathFinderService.FindShortestPath(eulynx, uuidStart, uuidEnd);
            PositioningNetElement[] allNetElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

            paintFoundPath(shortestPath, allNetElements);

            if(shortestPath.Length == 0)
            {
                listbox_show(new []{ "No paths found" });
            }
            else
            {
                listbox_show(new []{ "" });
            }
        }

        private void listbox_show(object[] objects)
        {
            listBox_content.Items.Clear();

            if(objects != null)
            {
                listBox_content.Items.AddRange(objects);
            }
        }

        private void button_netEntities_Click(object sender, EventArgs e)
        {
            if (this.paintedPath == null) return;

            TrackAssetManager trackAssetManager = InstanceManager.Singleton<TrackAssetManager>().GetInstance();
            var t = trackAssetManager.GetTrackAssets(eulynx);

            //BaseLocation[] allLocations = this.eulynx.ownsRtmEntities.usesSpotLocation.Where(sl => sl is SpotLocationCoordinate).Cast<SpotLocationCoordinate>().ToArray();
            //LocatedNetEntity[] allNetEntities = this.eulynx.ownsRtmEntities.ownsSignal;
            TrackAsset[] pathTrackAssets = trackAssetManager.GetTrackAssets(eulynx, this.paintedPath);

            //LocatedNetEntity[] netEntities = netEntityLocator.GetAssetsOnPath(this.paintedPath, allLocations, allNetEntities);

            listbox_show(pathTrackAssets);
        }

        private void groupBox_drawing_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            using(Brush brush = new SolidBrush(System.Drawing.Color.Black))
            {
                using (Pen pen = new Pen(brush, 5))
                {
                    var pt1 = new System.Drawing.Point(0, 0);
                    var pt2 = new System.Drawing.Point(100, 100);
                    g.DrawLine(pen, pt1, pt2);
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            var trackTopo = this.eulynx?.ownsRtmEntities?.usesTrackTopology;
            if (trackTopo == null) return;

            fillComboBoxPathFindEnd(trackTopo.usesPositioningNetElement.Select(n => n.uuid).ToArray());

            comboBox_pathFindStart.SelectedItem = null;
            comboBox_pathFindStart.Text = null;
            comboBox_pathFindEnd.SelectedItem = null;
            comboBox_pathFindEnd.Text = null;

            PositioningNetElement[] allNetElements = this.eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;
            paintFoundPath(new PositioningNetElement[] { }, allNetElements);

            listbox_show(new []{ "" });
        }
    }
}
