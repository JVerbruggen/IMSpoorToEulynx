using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public partial class IntrinsicCoordinate
    {
        public IntrinsicCoordinate()
        {

        }

        public IntrinsicCoordinate(List<tElementWithIDref> positioningSystemCoordinates, string id)
        {
            this.coordinates = positioningSystemCoordinates;
            this.id = id;
        }

        public IntrinsicCoordinate(List<tElementWithIDref> positioningSystemCoordinates)
        {
            this.coordinates = positioningSystemCoordinates;
        }
    }
}
