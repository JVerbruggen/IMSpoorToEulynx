using Models.Base;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Mapping.Topology
{
    public class PositioningNetElementMappingDepends : IMappingDepends<PositioningNetElement>
    {
        public PositionedRelation[] PositionedRelations { get; }
        public MicroLink MicroLink { get; }

        public PositioningNetElementMappingDepends(PositionedRelation[] positionedRelations, MicroLink microLink)
        {
            PositionedRelations = positionedRelations;
            MicroLink = microLink;
        }
    }
}
