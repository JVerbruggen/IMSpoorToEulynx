using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
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
    public class SignalMappingDefault : IMapping<Models.TopoModels.IMSpoor.V1_2_3.Signal, Models.TopoModels.Eulynx.EULYNX_Signalling.Signal>
    {
        public Models.TopoModels.Eulynx.EULYNX_Signalling.Signal Map(Models.TopoModels.IMSpoor.V1_2_3.Signal input)
        {
            SpotLocationManager spotLocationManager = InstanceManager.Singleton<SpotLocationManager>().GetInstance();
            SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
            SignalRTMManager signalRTMManager = InstanceManager.Singleton<SignalRTMManager>().GetInstance();

            SpotLocation geoSpotLocation = spotLocationManager.GetGeoLocation(input.Location);
            //SpotLocation linearSpotLocation = spotLocationManager.GetLineLocation(imspoorSignal.Location);

            spotLocationManager.Register(geoSpotLocation);

            var rtmSignal = new Models.TopoModels.Eulynx.Signalling.Signal((tElementWithIDref)geoSpotLocation);
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
            var signal = new Models.TopoModels.Eulynx.EULYNX_Signalling.Signal(uuid, null, geoSpotLocation, signalFramesRefs, FixingTypes.foundation, null, rtmSignal, null, null);

            return signal;
        }
    }
}
