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

        public virtual TrackAsset[] GetTrackAssets(Eulynx eulynx, PositioningNetElement[] path)
        {
            IList<TrackAsset> foundAssets = new List<TrackAsset>();

            BaseLocation[] allLocations = eulynx.ownsRtmEntities.usesSpotLocation;
            TrackAsset[] allAssets = GetTrackAssets(eulynx);
            foreach (TrackAsset asset in allAssets)
            {
                BaseLocation location = asset.GetLocation(allLocations);

                if (location is SpotLocation)
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
