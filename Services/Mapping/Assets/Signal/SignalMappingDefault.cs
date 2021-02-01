using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.sig;
using Services.Extensions;
using Services.Managers.Assets;
using Services.Managers.Location;
using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Mapping.Assets.Signal
{
    public class SignalMappingDefault : IMapping<Models.TopoModels.IMSpoor.V1_2_3.Signal, Models.TopoModels.EULYNX.sig.Signal>
    {
        private SpotLocationManager spotLocationManager;
        private SignalFrameManager signalFrameManager;
        private SignalRTMManager signalRTMManager;

        public SignalMappingDefault(SpotLocationManager spotLocationManager, SignalFrameManager signalFrameManager, SignalRTMManager signalRTMManager)
        {
            this.spotLocationManager = spotLocationManager;
            this.signalFrameManager = signalFrameManager;
            this.signalRTMManager = signalRTMManager;
        }

        public Models.TopoModels.EULYNX.sig.Signal Map(Models.TopoModels.IMSpoor.V1_2_3.Signal input)
        {
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

            //geoSpotLocation.netElement = new tElementWithIDref(imspoorRailconnectionInfo[0].railConnectionRef);

            IEnumerable<SignalFrame> signalFrames = signalFrameManager.GetSignalFrames();
            IEnumerable<tElementWithIDref> signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);
            signalFrameManager.Register(signalFrames);

            string uuid = input.puic;
            var signal = new Models.TopoModels.EULYNX.sig.Signal(uuid, geoSpotLocation, signalFramesRefs.ToList(), FixingTypes.foundation, null, rtmSignal, null, null);

            return signal;
        }
    }
}
