using Services.Mapping.Base;
using System;
using System.Collections.Generic;
using System.Text;
using SignalIMSpoor = Models.TopoModels.IMSpoor.V1_2_3.Signal;
using SignalEULYNX = Models.TopoModels.EULYNX.sig.Signal;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.Managers.Location;
using Services.Managers.Assets;
using Services.DependencyInjection;

namespace Services.Mapping.Assets.Signal
{
    public class SignalMappingSelector : MappingSelector<SignalIMSpoor, SignalEULYNX>
    {
        private SpotLocationManager spotLocationManager;
        private SignalFrameManager signalFrameManager;
        private SignalRTMManager signalRTMManager;

        public SignalMappingSelector(SpotLocationManager spotLocationManager, SignalFrameManager signalFrameManager, SignalRTMManager signalRTMManager)
        {
            this.spotLocationManager = spotLocationManager;
            this.signalFrameManager = signalFrameManager;
            this.signalRTMManager = signalRTMManager;
        }

        public override IMapping<SignalIMSpoor, SignalEULYNX> Select(SignalIMSpoor input)
        {
            IMapping<SignalIMSpoor, SignalEULYNX> mapping;
            if (input.signalType == tSignalEnum.Controlled)
            {
                mapping = new SignalMappingControlled();
            }
            else
            {
                mapping = new SignalMappingDefault(spotLocationManager, signalFrameManager, signalRTMManager);
            }
            return mapping;
        }
    }
}
