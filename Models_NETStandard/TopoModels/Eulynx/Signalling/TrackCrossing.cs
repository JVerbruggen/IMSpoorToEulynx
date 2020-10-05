using Models.DependencyInjection.Manager;
using Models.Location;
using Models.Service;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class TrackCrossing
    {
        public TrackCrossing()
        {

        }

        public TrackCrossing(LevelCrossing levelCrossing)
        {
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();

            this.isLocatedAt = new tElementWithIDref[] { spotLocationManager.GetGeoLocationRef(levelCrossing.Location) };
            this.streetName = levelCrossing.locationIndication;
            this.type = levelCrossing.levelCrossingType.ToString();

            this.uuid = UUIDService.NewFakeUUID(this.isLocatedAt + this.streetName + this.type);
        }



    }
}
