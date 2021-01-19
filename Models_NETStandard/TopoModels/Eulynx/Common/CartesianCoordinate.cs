using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class CartesianCoordinate
    {
        public CartesianCoordinate()
        {

        }

        public CartesianCoordinate(double x, double y, tElementWithIDref positioningSystem, string id)
        {
            this.x = x;
            this.y = y;
            this.positioningSystem = positioningSystem;
            this.id = id;
        }
    }
}
