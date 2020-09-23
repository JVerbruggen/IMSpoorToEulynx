using Models.Service;
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

        public SpotLocationCoordinate(String positioningSystemCoordinateRef)
        {
            this.coordinate = new tElementWithIDref(positioningSystemCoordinateRef);
            this.uuid = UUIDService.NewFakeUUID(positioningSystemCoordinateRef);
        }

    }
}
