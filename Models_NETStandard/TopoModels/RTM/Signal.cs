using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmSig
{
    public partial class Signal
    {
        public Signal()
        {

        }
        public Signal(tElementWithIDref location)
        {
            this.locations = tElementWithIDref.GetTElementsWithIDreflist(location);
        }

        public Signal(List<tElementWithIDref> locations)
        {
            this.locations = locations;
        }

        [Obsolete("Uses SpotLocationCoordinate, is gone")]
        public SpotLocationCoordinate GetLocation(List<BaseLocation> allLocations)
        {
            var locationRefs = this.locations;
            if (locationRefs.Count == 0) return null;
            var locations = allLocations.Where(loc => locationRefs.Any(@ref => @ref.GetRef() == loc.id));
            var specificLocations = BaseLocation.Filter<SpotLocationCoordinate>(allLocations);

            //return (SpotLocationCoordinate)specificLocations.FirstOrDefault();
            return null;
        }
    }
}
