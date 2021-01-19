using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.sig;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Assets;
using Services.Managers.Location;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Mapping.Assets.Signal
{
    public class SignalMappingDefault : IMapping<Models.TopoModels.IMSpoor.V1_2_3.Signal, Models.TopoModels.EULYNX.sig.Signal>
    {
        public Models.TopoModels.EULYNX.sig.Signal Map(Models.TopoModels.IMSpoor.V1_2_3.Signal input)
        {
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();
            SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
            SignalRTMManager signalRTMManager = InstanceManager.Singleton<SignalRTMManager>().GetInstance();

            SpotLocation geoSpotLocation = spotLocationManager.GetGeoLocation(input.Location);
            spotLocationManager.Register(geoSpotLocation);

            //SpotLocation linearSpotLocation = spotLocationManager.GetLineLocation(imspoorSignal.Location);

            var rtmSignal = new Models.TopoModels.EULYNX.rtmSig.Signal((tElementWithIDref)geoSpotLocation);
            rtmSignal.AllocateUUID();
            signalRTMManager.Register(rtmSignal);

            var imspoorRailconnectionInfo = input.RailConnectionInfo;
            if (imspoorRailconnectionInfo.Length >= 2)
            {
                throw new NotImplementedException("Een sein met meerdere rail connecties!");
            }

            geoSpotLocation.netElement = new tElementWithIDref(imspoorRailconnectionInfo[0].railConnectionRef);

            SignalFrame[] signalFrames = signalFrameManager.GetSignalFrames();
            tElementWithIDref[] signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);
            signalFrameManager.Register(signalFrames);

            string uuid = input.puic;
            var signal = new Models.TopoModels.EULYNX.sig.Signal(uuid, geoSpotLocation, signalFramesRefs, FixingTypes.foundation, null, rtmSignal, null, null);
            //var signal = new Models.TopoModels.EULYNX.sig.Signal(uuid, null, geoSpotLocation, signalFramesRefs, FixingTypes.foundation, null, rtmSignal, null, null);

            return signal;
        }
    }
}
