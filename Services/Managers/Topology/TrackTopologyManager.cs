using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Topology
{
    public class TrackTopologyManager : AbstractManager<TrackTopology>
    {
        public TrackTopology GetTrackTopology(RailTopology railTopology)
        {
            PositionedRelation[] positionedRelations = InstanceManager.Singleton<PositionedRelationManager>().GetInstance().GetPositionedRelations(railTopology);
            PositioningNetElement[] positioningNetElements = InstanceManager.Singleton<PositioningNetElementManager>().GetInstance().GetPositioningNetElements(railTopology.MicroLinks);

            TrackTopology trackTopology = new TrackTopology(positionedRelations, positioningNetElements);

            return trackTopology;
        }
    }
}
