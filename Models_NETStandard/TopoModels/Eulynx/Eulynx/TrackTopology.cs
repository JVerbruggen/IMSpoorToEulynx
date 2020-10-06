using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class TrackTopology
    {
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
