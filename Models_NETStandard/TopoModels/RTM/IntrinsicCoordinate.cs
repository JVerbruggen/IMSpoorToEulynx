using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class IntrinsicCoordinate
    {
        public IntrinsicCoordinate()
        {

        }

        public IntrinsicCoordinate(tElementWithIDref[] positioningSystemCoordinates, string uuid)
        {
            this.coordinates = positioningSystemCoordinates;
            this.uuid = uuid;
        }

        public IntrinsicCoordinate(tElementWithIDref[] positioningSystemCoordinates)
        {
            this.coordinates = positioningSystemCoordinates;
        }
    }
}
