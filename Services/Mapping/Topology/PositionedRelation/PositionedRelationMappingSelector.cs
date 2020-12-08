using Models.Mapping.Topology;
using Services.Managers.Topology;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Topology
{
    public class PositionedRelationMappingSelector : MappingSelector<PositionedRelationMappingDepends, PositionedRelationMappingResult>
    {
        public PositionedRelationManager positionedRelationManager { get; }

        public PositionedRelationMappingSelector(PositionedRelationManager positionedRelationManager)
        {
            this.positionedRelationManager = positionedRelationManager;
        }

        public override IMapping<PositionedRelationMappingDepends, PositionedRelationMappingResult> Select(PositionedRelationMappingDepends input)
        {
            return new PositionedRelationMapping(positionedRelationManager);
        }
    }
}
