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
    public class TrackAssetManagerDefault : TrackAssetManager
    {
        public override TrackAsset[] GetTrackAssets(Eulynx eulynx)
        {
            return eulynx.ownsSignallingEntities.ownsSignal;
        }
    }
}
