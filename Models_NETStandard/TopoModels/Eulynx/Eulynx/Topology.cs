using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.dp
{
    public partial class Topology
    {
        public Topology()
        {

        }

        public Topology(List<PositionedRelation> usesPositionedRelation, List<PositioningNetElement> usesPositioningNetElement)
        {
            this.usesPositionedRelation = usesPositionedRelation;
            this.usesPositioningNetElement = usesPositioningNetElement;
        }
    }
}
