using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Signal
    {

        public static Signal GetSignal()
        {
            Signal signal = new Signal();

            signal.locations = tElementWithIDref.GetTElementsWithIDref();
            signal.longname = "";
            signal.name = "";
            signal.uuid = "";

            return signal;
        }

        public static Signal[] GetSignals()
        {
            Signal[] signals = { };



            return signals;
        }

    }
}
