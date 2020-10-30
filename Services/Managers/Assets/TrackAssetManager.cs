using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public abstract class TrackAssetManager : ItemManager<TrackAsset>
    {
        public abstract TrackAsset[] GetTrackAssets(Eulynx eulynx);

        //public abstract TrackAsset[] GetTrackAssets<T>(Eulynx eulynx) where T : BaseObject;

        public TrackAsset[] GetTrackAssets(IEnumerable<TrackAsset> allTrackAssets, IEnumerable<BaseLocation> allSpotLocations, PositioningNetElement[] path)
        {
            if (allTrackAssets == null
                || allSpotLocations == null
                || path == null) return null;

            IList<TrackAsset> foundAssets = new List<TrackAsset>();

            foreach (TrackAsset asset in allTrackAssets)
            {
                BaseLocation location = asset.GetLocation(allSpotLocations);

                if (location is SpotLocation)
                {
                    tElementWithIDref spotLocationRef = (location as SpotLocation).netElement;

                    bool c = path.Any(netElement => netElement.uuid.Equals(spotLocationRef.@ref));
                    if (c)
                    {
                        bool a = false;
                    }

                    var found = BaseLocation.Find(path, spotLocationRef);
                    if (found != null)
                    {
                        foundAssets.Add(asset);
                    }
                }
            }

            return foundAssets.ToArray();
        }

        public virtual TrackAsset[] GetTrackAssets(Eulynx eulynx, PositioningNetElement[] path)
        {
            BaseLocation[] allLocations = eulynx.ownsRtmEntities.usesSpotLocation;
            TrackAsset[] allAssets = GetTrackAssets(eulynx);

            return GetTrackAssets(allAssets, allLocations, path);
        }
    }
}
