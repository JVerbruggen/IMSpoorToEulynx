using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    [Obsolete]
    public partial class SpotLocationCoordinate
    {
        private tElementWithIDref coordinate;
        private string uuid;

        public SpotLocationCoordinate()
        {

        }

        [Obsolete]
        public SpotLocationCoordinate(tElementWithIDref positioningSystemCoordinate, string uuid)
        {
            this.coordinate = positioningSystemCoordinate;
            this.uuid = uuid;
        }
    }
}
