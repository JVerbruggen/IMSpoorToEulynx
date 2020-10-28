using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.DependencyInjection;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Service;
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
                SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
                SignalRTMManager signalRTMManager = InstanceManager.Singleton<SignalRTMManager>().GetInstance();

                SpotLocation spotLocation = spotLocationManager.GetGeoLocation(imspoorSignal.Location);
                spotLocationManager.Register(spotLocation);

                var rtmSignal = new Models.TopoModels.Eulynx.Signalling.Signal(spotLocation);
                rtmSignal.uuid = UUIDService.NewFakeUUID(rtmSignal);
                signalRTMManager.Register(rtmSignal);

                spotLocation.netElement = rtmSignal;

                SignalFrame[] signalFrames = signalFrameManager.GetSignalFrames();
                tElementWithIDref[] signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);
                signalFrameManager.Register(signalFrames);

                string uuid = imspoorSignal.puic;
                Signal signal = new Signal(uuid, null, spotLocation, signalFramesRefs, FixingTypes.foundation, null, rtmSignal, null, null);
                signalsConverted.Add(signal);
            }
            return signalsConverted.ToArray();
        }

    }
}
