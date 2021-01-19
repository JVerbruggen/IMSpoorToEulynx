using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.rtmCommon
{
    public abstract partial class Quantity
    {
        public Quantity()
        {

        }

        public Quantity(double value)
        {
            this.value = value;
            this.unit = new tElementWithIDref("someUnit");
            this.quantityKind = new tElementWithIDref("someQuantityKind");
        }

        public Quantity(double value, tElementWithIDref unit, tElementWithIDref quantityKind)
        {
            this.quantityKind = quantityKind;
            this.unit = unit;
            this.value = value;
        }
    }
}
