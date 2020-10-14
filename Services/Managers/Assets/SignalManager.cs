using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public class SignalManager : ItemManager<Signal>
    {
        public Signal[] GetSignals(Models.TopoModels.IMSpoor.V1_3_0.Signal[] imspoorSignals)
        {
            IList<Signal> signalsConverted = new List<Signal>();
            foreach (Models.TopoModels.IMSpoor.V1_3_0.Signal imspoorSignal in imspoorSignals)
            {
                SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();

                SpotLocation spotLocation = spotLocationManager.GetGeoLocation(imspoorSignal.Location);
                spotLocationManager.Register(spotLocation);
                tElementWithIDref location = new tElementWithIDref(spotLocation.uuid);
                var rtmSignal = new Models.TopoModels.Eulynx.Signalling.Signal(location);
                InstanceManager.Singleton<SignalRTMManager>().GetInstance().Register(rtmSignal);

                SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
                SignalFrame[] signalFrames = signalFrameManager.GetSignalFrames();
                tElementWithIDref[] signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);

                Signal signal = new Signal(imspoorSignal, rtmSignal, signalFramesRefs);
                signalsConverted.Add(signal);
            }
            return signalsConverted.ToArray();
        }

    }
}
