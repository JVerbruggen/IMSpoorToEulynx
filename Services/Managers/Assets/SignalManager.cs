using Services.DependencyInjection;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SignalIMSpoor = Models.TopoModels.IMSpoor.V1_2_3.Signal;
using SignalEULYNX = Models.TopoModels.EULYNX.sig.Signal;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.dp;

namespace Services.Managers.Assets
{
    public class SignalManager : ItemManager<SignalEULYNX>
    {

        public List<SignalEULYNX> GetSignals(SignalIMSpoor[] imspoorSignals)
        {
            List<SignalEULYNX> signalsConverted = new List<SignalEULYNX>();
            foreach (SignalIMSpoor imspoorSignal in imspoorSignals)
            {
                SignalEULYNX signal = InstanceManager.GetMappingSelector<SignalIMSpoor, SignalEULYNX>().Map(imspoorSignal);

                if (signal == null) continue;

                signalsConverted.Add(signal);
                this.Register(signal);
            }
            return signalsConverted;
        }

        [Obsolete("SpotLocationCoordinate is obsolete")]
        public BaseLocation GetLocation(SignalEULYNX signal)
        {
            tElementWithIDref rtmSignalRef = signal.refersToRsmSignal; 

            EulynxDataPrep eulynx = InstanceManager.Singleton<EulynxDataPrep>().GetInstance();
            var rtmSignals = eulynx.ownsRtmEntities.ownsSignal;

            var spotLocations = eulynx.ownsRtmEntities.usesSpotLocation;

            var rtmSignal = BaseObject.Find(rtmSignals, rtmSignalRef);
            var rtmSignalLocationsRef = rtmSignal.locations;
            //var rtmSignalSpotLocation = rtmSignal.GetLocation(spotLocations);

            //return rtmSignalSpotLocation;
            return null;
        }

    }
}
