using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class SpotLocationCoordinate
    {
        public SpotLocationCoordinate()
        {

        }

        public SpotLocationCoordinate(tElementWithIDref positioningSystemCoordinate, string uuid)
        {
            this.coordinate = positioningSystemCoordinate;
            this.uuid = uuid;
        }
    }
}
