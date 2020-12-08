using Models.Base;
using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Mapping.Topology
{
    public class PositionedRelationMappingResult : IMappingResult<PositionedRelation>
    {
        public PositionedRelation[] PositionedRelations { get; }

        public PositionedRelationMappingResult(PositionedRelation[] positionedRelations)
        {
            PositionedRelations = positionedRelations;
        }
    }
}
