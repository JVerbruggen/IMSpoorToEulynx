using Models.TopoModels.IMSpoor;
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

        public CartesianCoordinate(double x, double y, tElementWithIDref positioningSystem, string uuid)
        {
            this.x = x;
            this.y = y;
            this.positioningSystem = positioningSystem;
            this.uuid = uuid;
        }
    }
}
