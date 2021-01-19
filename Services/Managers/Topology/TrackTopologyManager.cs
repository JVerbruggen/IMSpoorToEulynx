using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Topology
{
    [Obsolete("Tracktopology is obsolete")]
    public class TrackTopologyManager : AbstractManager<TrackTopology>
    {
        [Obsolete]
        public TrackTopology GetTrackTopology(RailTopology railTopology)
        {
            PositionedRelation[] positionedRelations = InstanceManager.Singleton<PositionedRelationManager>().GetInstance().GetPositionedRelations(railTopology);
            PositioningNetElement[] positioningNetElements = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance().GetPositioningNetElements(railTopology.MicroLinks, positionedRelations);

            TrackTopology trackTopology = new TrackTopology(positionedRelations, positioningNetElements);

            return trackTopology;
        }

        [Obsolete]
        public Models.TopoModels.EULYNX.dp.Topology GetTopology(RailTopology railTopology)
        {
            PositionedRelation[] positionedRelations = InstanceManager.Singleton<PositionedRelationManager>().GetInstance().GetPositionedRelations(railTopology);
            PositioningNetElement[] positioningNetElements = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance().GetPositioningNetElements(railTopology.MicroLinks, positionedRelations);

            TrackTopology trackTopology = new TrackTopology(positionedRelations, positioningNetElements);

            return null;
        }
    }
}
