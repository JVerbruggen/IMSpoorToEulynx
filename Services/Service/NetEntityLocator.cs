using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.NetEntity;
using Models.Translation;
using Services.DependencyInjection;
using Services.Managers.Location;
using Services.Managers.NetEntity;
using Services.Managers.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Service
{
    public class NetEntityLocator : IService
    {
        public LocatedNetEntity[] GetAssetsOnPath(PositioningNetElement[] orderedPath, BaseLocation[] allLocations, LocatedNetEntity[] allNetEntities)
        {
            List<LocatedNetEntity> pathNetEntities = new List<LocatedNetEntity>();

            foreach (PositioningNetElement pathElement in orderedPath)
            {
                LocatedNetEntity[] netEntities = InstanceManager.Singleton<LocatedNetEntityManager>().GetInstance().GetLocatedNetEntities(allLocations, allNetEntities, pathElement);

                pathNetEntities.AddRange(netEntities);
            }

            return pathNetEntities.ToArray();
        }

    }
}
