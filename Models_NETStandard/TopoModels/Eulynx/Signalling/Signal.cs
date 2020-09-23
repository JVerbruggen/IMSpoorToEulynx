using Models.DependencyInjection.Manager;
using Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Signal
    {

        public static Signal GetSignal()
        {
            Signal signal = new Signal();

            signal.locations = tElementWithIDref.GetTElementsWithIDref();
            signal.longname = "";
            signal.name = "";
            signal.uuid = "";

            return signal;
        }

        public static Signal[] GetSignals()
        {
            Signal[] signals = { };



            return signals;
        }

        public Signal[] TranslateMultiple(IMSpoor.Signal[] signals)
        {
            IList<Signal> signalsConverted = new List<Signal>();
            foreach(IMSpoor.Signal signal in signals)
            {
                SpotLocationManager spotLocationManager = InstanceManager.GetOrNewInstanceSupplier<SpotLocationManager>().GetInstance();

                SpotLocation spotLocation = spotLocationManager.GetGeoLocation(signal.Location);
                spotLocationManager.Register(spotLocation);

                tElementWithIDref[] locations = { new tElementWithIDref(spotLocation.uuid) };

                Signal signalConverted = new Signal()
                {
                    uuid = signal.puic,
                    name = "signalname",
                    locations = locations
                };
                signalsConverted.Add(signalConverted);
            }
            return signalsConverted.ToArray();

        }

    }
}
