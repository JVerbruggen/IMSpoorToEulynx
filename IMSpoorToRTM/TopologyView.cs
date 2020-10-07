using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Models.TopoModels.Eulynx;
using Services.DependencyInjection;
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

        public TopologyView()
        {
            InitializeComponent();
        }

        public TopologyView(Eulynx eulynx)
        {
            this.eulynx = eulynx;
            InitializeComponent();

            this.viewer = new GViewer();
            this.graph = new Graph("MyGraph");

            foreach(PositioningNetElement netElement in eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement)
            {
                comboBox_pathFindStart.Items.Add(netElement.uuid);
                comboBox_pathFindEnd.Items.Add(netElement.uuid);
            }

            PositionedRelation[] relations = eulynx.ownsRtmEntities.usesTrackTopology.usesPositionedRelation;
            foreach(PositionedRelation relation in relations)
            {
                string refA = relation.elementA.@ref;
                string refB = relation.elementB.@ref;

                if (refA == null || refB == null) continue;

                this.graph.AddEdge(refA, refB);
            }

            this.viewer.Graph = this.graph;

            this.SuspendLayout();
            this.viewer.Dock = DockStyle.Fill;
            this.groupBox_drawing.Controls.Add(this.viewer);
            this.ResumeLayout();
        }

        private void paintFoundPath(PositioningNetElement[] path, PositioningNetElement[] allElements)
        {
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

        public void FindShortestPath(string refStartNetElement, string refEndNetElement)
        {
            if (this.eulynx == null) return;

            PositioningNetElementManager positioningNetElementManager = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance();

            PositionedRelation[] relations = eulynx.ownsRtmEntities.usesTrackTopology.usesPositionedRelation;
            PositioningNetElement[] netElements = eulynx.ownsRtmEntities.usesTrackTopology.usesPositioningNetElement;

            PositioningNetElement startNetElement = positioningNetElementManager.Find(netElements, refStartNetElement);
            PositioningNetElement endNetElement = positioningNetElementManager.Find(netElements, refEndNetElement);

            PositioningNetElement[] shortestPath = InstanceManager.Singleton<PathFinderService>().GetInstance().FindShortestPath(relations, netElements, startNetElement, endNetElement);

            paintFoundPath(shortestPath, netElements);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button_findPathSubmit_Click(object sender, EventArgs e)
        {
            string uuidStart = comboBox_pathFindStart.SelectedItem.ToString();
            string uuidEnd = comboBox_pathFindEnd.SelectedItem.ToString();

            FindShortestPath(uuidStart, uuidEnd);
        }
    }
}
