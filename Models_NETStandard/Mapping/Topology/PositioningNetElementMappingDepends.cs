using Models.Base;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Mapping.Topology
{
    public class PositioningNetElementMappingDepends : IMappingDepends<PositioningNetElement>
    {
        public IEnumerable<PositionedRelation> PositionedRelations { get; }
        public MicroLink MicroLink { get; }

        public PositioningNetElementMappingDepends(IEnumerable<PositionedRelation> positionedRelations, MicroLink microLink)
        {
            PositionedRelations = positionedRelations;
            MicroLink = microLink;
        }
    }
}
