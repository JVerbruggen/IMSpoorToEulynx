using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.EULYNX.rtmCommon;
using Models.TopoModels.EULYNX.sig;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public abstract class TrackAssetManager : ItemManager<TrackAsset>
    {
        public abstract List<TrackAsset> GetTrackAssets(EulynxDataPrep eulynx);

        //public abstract TrackAsset[] GetTrackAssets<T>(Eulynx eulynx) where T : BaseObject;

        public List<TrackAsset> GetTrackAssets(IEnumerable<TrackAsset> allTrackAssets, IEnumerable<BaseLocation> allSpotLocations, List<PositioningNetElement> path)
        {
            if (allTrackAssets == null
                || allSpotLocations == null
                || path == null) return null;

            List<TrackAsset> foundAssets = new List<TrackAsset>();

            foreach (TrackAsset asset in allTrackAssets)
            {
                BaseLocation location = asset.GetLocation(allSpotLocations);

                if (location is SpotLocation)
                {
                    tElementWithIDref spotLocationRef = (location as SpotLocation).netElement;

                    bool c = path.Any(netElement => netElement.id.Equals(spotLocationRef.GetRef()));
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

            return foundAssets;
        }

        public virtual List<TrackAsset> GetTrackAssets(EulynxDataPrep eulynx, List<PositioningNetElement> path)
        {
            List<BaseLocation> allLocations = eulynx.ownsRtmEntities.usesSpotLocation.Cast<BaseLocation>().ToList();
            List<TrackAsset> allAssets = GetTrackAssets(eulynx);

            return GetTrackAssets(allAssets, allLocations, path);
        }
    }
}
