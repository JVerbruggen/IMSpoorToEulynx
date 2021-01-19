using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.sig;
using Services.DependencyInjection;
using Services.Factory.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public class TrackAssetManagerLimited : TrackAssetManager
    {
        public override List<TrackAsset> GetTrackAssets(EulynxDataPrep eulynx)
        {
            List<TrackAsset> trackAssets = new List<TrackAsset>();

            Signal[] signals = eulynx.ownsRtmEntities.ownsSignal.Select(s => InstanceManager.Singleton<Signal>().GetInstance()).ToArray(); // Should be, when available, signallingEntities.ownsSignal

            trackAssets.AddRange(signals);

            return trackAssets;
        }
    }
}
