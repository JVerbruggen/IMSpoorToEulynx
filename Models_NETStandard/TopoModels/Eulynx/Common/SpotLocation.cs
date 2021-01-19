using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class SpotLocation
    {
        [Obsolete("Not used: gone obsolete")]
        public tElementWithIDref netElement;

        public static SpotLocation[] GetSpotLocations()
        {
            SpotLocation[] spotLocations = { };

            return spotLocations;
        }

    }
}
