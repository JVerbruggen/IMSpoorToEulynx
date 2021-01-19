using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.dp
{
    [Obsolete("use Topology")]
    public partial class TrackTopology
    {
        private PositionedRelation[] usesPositionedRelation;
        private PositioningNetElement[] usesPositioningNetElement;

        public TrackTopology()
        {

        }

        public TrackTopology(PositionedRelation[] positionedRelations, PositioningNetElement[] positioningNetElements)
        {
            this.usesPositionedRelation = positionedRelations;
            this.usesPositioningNetElement = positioningNetElements;
        }
    }
}
