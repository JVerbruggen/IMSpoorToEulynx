using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DpTopology = Models.TopoModels.EULYNX.dp.Topology;

namespace Services.Managers.Topology
{
    public class TopologyManager : AbstractManager<DpTopology>
    {
        public DpTopology GetTopology(RailTopology railTopology)
        {
            IEnumerable<PositionedRelation> positionedRelations = InstanceManager.Singleton<PositionedRelationManager>().GetInstance().GetPositionedRelations(railTopology);
            IEnumerable<PositioningNetElement> positioningNetElements = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance().GetPositioningNetElements(railTopology.MicroLinks, positionedRelations);

            DpTopology topology = new DpTopology(positionedRelations.ToList(), positioningNetElements.ToList());

            return topology;
        }
    }
}
