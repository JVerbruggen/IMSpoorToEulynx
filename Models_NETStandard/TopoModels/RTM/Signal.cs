using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.Signalling
{
    public partial class Signal
    {
        public Signal()
        {

        }
        public Signal(tElementWithIDref location)
        {
            this.locations = tElementWithIDref.GetTElementsWithIDref(location);
        }
    }
}
