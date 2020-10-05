using Models.DependencyInjection.Manager;
using Models.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Signal
    {
        public Signal()
        {

        }

        public Signal(tElementWithIDref[] locations)
        {
            this.locations = locations;
            this.name = "RTMSignal";
        }

        public Signal(IMSpoor.V1_3_0.Signal imspoorSignal)
        {
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();

            SpotLocation spotLocation = spotLocationManager.GetGeoLocation(imspoorSignal.Location);
            spotLocationManager.Register(spotLocation);
            this.locations = new tElementWithIDref[] { new tElementWithIDref(spotLocation.uuid) };
        }
    }
}
