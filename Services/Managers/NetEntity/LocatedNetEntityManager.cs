using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.rtmNE;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.NetEntity
{
    public class LocatedNetEntityManager : ItemManager<LocatedNetEntity>
    {
        public LocatedNetEntity[] GetLocatedNetEntities(BaseLocation[] allLocations, LocatedNetEntity[] allNetEntities, PositioningNetElement positioningNetElement)
        {
            IList<LocatedNetEntity> localNetEntities = new List<LocatedNetEntity>();

            foreach (LocatedNetEntity netEntity in allNetEntities)
            {
                tElementWithIDref[] netEntityLocationRefs = netEntity.locations;
                BaseLocation[] netEntityLocations = BaseLocation.Find(allLocations, netEntityLocationRefs);

                foreach(BaseLocation netEntityLocation in netEntityLocations)
                {
                    if(netEntityLocation is SpotLocation)
                    {
                        tElementWithIDref netElementRef = (netEntityLocation as SpotLocation).netElement;
                        if(positioningNetElement.Equals(netElementRef))
                        {
                            localNetEntities.Add(netEntity);
                            break;
                        }
                    }
                }
            }

            return localNetEntities.ToArray();
        }
    }
}
