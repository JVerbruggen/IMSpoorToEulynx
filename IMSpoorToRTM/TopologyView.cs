using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using Models.TopoModels.Eulynx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class TopologyView : Form
    {
        public TopologyView()
        {
            InitializeComponent();
        }

        public TopologyView(Eulynx eulynx)
        {
            InitializeComponent();

            GViewer viewer = new GViewer();
            Graph graph = new Graph("MyGraph");

            PositionedRelation[] relations = eulynx.ownsRtmEntities.usesTrackTopology.usesPositionedRelation;
            foreach(PositionedRelation relation in relations)
            {
                graph.AddEdge(relation.elementA.@ref, relation.elementB.@ref);
            }

            viewer.Graph = graph;

            this.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            this.Controls.Add(viewer);
            this.ResumeLayout();
        }
    }
}
