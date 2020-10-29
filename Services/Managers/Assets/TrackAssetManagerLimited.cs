using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
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
        public override TrackAsset[] GetTrackAssets(Eulynx eulynx)
        {
            List<TrackAsset> trackAssets = new List<TrackAsset>();

            Signal[] signals = eulynx.ownsRtmEntities.ownsSignal.Select(s => InstanceManager.Singleton<Signal>().GetInstance()).ToArray(); // Should be, when available, signallingEntities.ownsSignal

            trackAssets.AddRange(eulynx.ownsSignallingEntities.ownsSignal);

            return trackAssets.ToArray();
        }
    }
}
