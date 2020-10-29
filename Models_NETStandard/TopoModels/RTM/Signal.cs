using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Signalling
{
    public partial class Signal
    {
        public Signal()
        {

        }
        public Signal(tElementWithIDref location)
        {
            this.locations = tElementWithIDref.GetTElementsWithIDref(location);
        }

        public SpotLocationCoordinate GetLocation(BaseLocation[] allLocations)
        {
            var locationRefs = this.locations;
            if (locationRefs.Length == 0) return null;
            var locations = allLocations.Where(loc => locationRefs.Any(@ref => @ref.@ref == loc.uuid));
            var specificLocations = BaseLocation.Filter<SpotLocationCoordinate>(allLocations);

            return (SpotLocationCoordinate)specificLocations.FirstOrDefault();
        }
    }
}
