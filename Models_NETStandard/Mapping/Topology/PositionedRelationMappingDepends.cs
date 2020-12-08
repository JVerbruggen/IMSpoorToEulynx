using Models.Base;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.IMSpoor.V1_2_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Mapping.Topology
{
    public class PositionedRelationMappingDepends : IMappingDepends<PositionedRelation>
    {
        public RailTopology RailTopology { get; }
        public MicroLink CurrentTrack { get; }

        public PositionedRelationMappingDepends(RailTopology railTopology, MicroLink currentTrack)
        {
            RailTopology = railTopology;
            CurrentTrack = currentTrack;
        }
    }
}
