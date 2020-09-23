using Models.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class CartesianCoordinate
    {
        public CartesianCoordinate()
        {

        }

        public CartesianCoordinate(double x, double y, String positioningSystemRef)
        {
            this.x = x;
            this.y = y;
            this.positioningSystem = new tElementWithIDref(positioningSystemRef);
            this.uuid = UUIDService.NewFakeUUID(x + "" + y + positioningSystemRef);
        }
    }
}
