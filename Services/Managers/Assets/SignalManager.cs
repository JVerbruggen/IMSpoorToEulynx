using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Services.DependencyInjection;
using Services.Extensions;
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
        public Signal[] GetSignals(Models.TopoModels.IMSpoor.V1_2_3.Signal[] imspoorSignals)
        {
            IList<Signal> signalsConverted = new List<Signal>();
            foreach (Models.TopoModels.IMSpoor.V1_2_3.Signal imspoorSignal in imspoorSignals)
            {
                SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();
                SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
                SignalRTMManager signalRTMManager = InstanceManager.Singleton<SignalRTMManager>().GetInstance();

                SpotLocation geoSpotLocation = spotLocationManager.GetGeoLocation(imspoorSignal.Location);
                //SpotLocation linearSpotLocation = spotLocationManager.GetLineLocation(imspoorSignal.Location);

                spotLocationManager.Register(geoSpotLocation);

                var rtmSignal = new Models.TopoModels.Eulynx.Signalling.Signal((tElementWithIDref)geoSpotLocation);
                rtmSignal.AllocateUUID();
                signalRTMManager.Register(rtmSignal);

                var imspoorRailconnectionInfo = imspoorSignal.RailConnectionInfo;
                if(imspoorRailconnectionInfo.Length >= 2)
                {
                    throw new NotImplementedException("Een sein met meerdere rail connecties!");
                }

                geoSpotLocation.netElement = new tElementWithIDref(imspoorRailconnectionInfo[0].railConnectionRef);

                SignalFrame[] signalFrames = signalFrameManager.GetSignalFrames();
                tElementWithIDref[] signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);
                signalFrameManager.Register(signalFrames);

                string uuid = imspoorSignal.puic;
                Signal signal = new Signal(uuid, null, geoSpotLocation, signalFramesRefs, FixingTypes.foundation, null, rtmSignal, null, null);
                signalsConverted.Add(signal);
                this.Register(signal);
            }
            return signalsConverted.ToArray();
        }

        public BaseLocation GetLocation(Signal signal)
        {
            tElementWithIDref rtmSignalRef = signal.refersToRtmSignal;

            Eulynx eulynx = InstanceManager.Singleton<Eulynx>().GetInstance();
            var rtmSignals = eulynx.ownsRtmEntities.ownsSignal;

            var spotLocations = eulynx.ownsRtmEntities.usesSpotLocation;

            var rtmSignal = BaseObject.Find(rtmSignals, rtmSignalRef);
            var rtmSignalLocationsRef = rtmSignal.locations;
            var rtmSignalSpotLocation = rtmSignal.GetLocation(spotLocations);

            return rtmSignalSpotLocation;
        }

    }
}
