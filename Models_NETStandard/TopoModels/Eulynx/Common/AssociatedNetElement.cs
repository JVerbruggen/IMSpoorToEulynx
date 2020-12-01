using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Common
{
    public partial class AssociatedNetElement
    {
        public AssociatedNetElement()
        {

        }

        public AssociatedNetElement(tElementWithIDref netElement)
        {
            this.appliesInDirection = ApplicationDirection.undefined;
            this.isLocatedToSide = LateralSide.undefined;
            this.netElement = netElement;
        }
    }
}
