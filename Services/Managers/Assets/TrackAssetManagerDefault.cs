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
    public class TrackAssetManagerDefault : TrackAssetManager
    {
        [Obsolete("ownsSignal no longer exists")]
        public override List<TrackAsset> GetTrackAssets(EulynxDataPrep eulynx)
        {
            return eulynx.ownsSignallingEntities.ownsSignal;
        }
    }
}
