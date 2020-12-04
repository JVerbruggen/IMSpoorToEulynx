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
using SignalEULYNX = Models.TopoModels.Eulynx.EULYNX_Signalling.Signal;

namespace Services.Managers.Assets
{
    public class SignalManager : ItemManager<SignalEULYNX>
    {

        public SignalEULYNX[] GetSignals(SignalIMSpoor[] imspoorSignals)
        {
            IList<SignalEULYNX> signalsConverted = new List<SignalEULYNX>();
            foreach (SignalIMSpoor imspoorSignal in imspoorSignals)
            {
                IMapping<SignalIMSpoor, SignalEULYNX> mapping = InstanceManager.GetMappingSelector<SignalIMSpoor, SignalEULYNX>().Select(imspoorSignal);
                SignalEULYNX signal = mapping.Map(imspoorSignal);

                if (signal == null) continue;

                signalsConverted.Add(signal);
                this.Register(signal);
            }
            return signalsConverted.ToArray();
        }

        public BaseLocation GetLocation(SignalEULYNX signal)
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
