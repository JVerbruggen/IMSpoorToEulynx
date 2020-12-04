using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Services.DependencyInjection;
using Services.Extensions;
using Services.Managers.Base;
using Services.Managers.Location;
using Services.Mapping.Assets.Signal;
using Services.Mapping.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SignalIMSpoor = Models.TopoModels.IMSpoor.V1_2_3.Signal;

namespace Services.Managers.Assets
{
    public class SignalManager : ItemManager<Signal>
    {
        public IMapping<SignalIMSpoor, Signal> GetMapping(SignalIMSpoor imspoorSignal)
        {
            IMapping<SignalIMSpoor, Signal> mapping;
            if (imspoorSignal.signalType == Models.TopoModels.IMSpoor.V1_2_3.tSignalEnum.Controlled)
            {
                mapping = new SignalMappingControlled();
            }
            else
            {
                mapping = new SignalMappingDefault();
            }
            return mapping;
        }

        public Signal[] GetSignals(SignalIMSpoor[] imspoorSignals)
        {
            IList<Signal> signalsConverted = new List<Signal>();
            foreach (SignalIMSpoor imspoorSignal in imspoorSignals)
            {
                IMapping<SignalIMSpoor, Signal> mapping = GetMapping(imspoorSignal);
                Signal signal = mapping.Map(imspoorSignal);

                if (signal == null) continue;

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
