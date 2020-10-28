using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Assets
{
    public class TrackAssetManager
    {
        public TrackAsset[] GetTrackAssets(Eulynx eulynx)
        {
            List<TrackAsset> trackAssets = new List<TrackAsset>();

            trackAssets.AddRange(eulynx.ownsSignallingEntities.ownsSignal);

            return trackAssets.ToArray();
        }

        public TrackAsset[] GetTrackAssets(Eulynx eulynx, PositioningNetElement[] path)
        {
            TrackAsset[] allAssets = GetTrackAssets(eulynx);


        }

    }
}
