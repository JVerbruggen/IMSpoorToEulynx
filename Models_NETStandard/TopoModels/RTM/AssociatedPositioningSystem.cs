using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_3_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class AssociatedPositioningSystem
    {
        public AssociatedPositioningSystem()
        {

        }

        public AssociatedPositioningSystem(IntrinsicCoordinate[] intrinsicCoordinates, tElementWithIDref positioningSystem)
        {
            this.intrinsicCoordinates = intrinsicCoordinates;
            this.positioningSystem = positioningSystem;
        }
    }
}
