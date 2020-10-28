using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using System;
using System.Collections.Generic;
using System.Linq;
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
            IList<TrackAsset> foundAssets = new List<TrackAsset>();

            BaseLocation[] allLocations = eulynx.ownsRtmEntities.usesSpotLocation;
            TrackAsset[] allAssets = GetTrackAssets(eulynx);
            foreach (TrackAsset asset in allAssets){
                BaseLocation location = asset.GetLocation(allLocations);

                if(location is SpotLocation)
                {
                    tElementWithIDref spotLocationRef = (location as SpotLocation).netElement;

                    bool c = path.Any(netElement => netElement.uuid.Equals(spotLocationRef.@ref));
                    if (c)
                    {
                        bool a = false;
                    }

                    var found = BaseLocation.Find(path, spotLocationRef);
                }
            }

            return foundAssets.ToArray();
        }

    }
}
