using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Signal
    {
        public Signal()
        {

        }

        public Signal(tElementWithIDref location)
        {
            this.hasLocation = location;
        }
    }
}
