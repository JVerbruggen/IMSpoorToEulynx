using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.Extensions;
using Services.Factory.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Assets
{
    public class SignalFactory : Factory<Signal>
    {
        public Signal GetSignal(Models.TopoModels.Eulynx.Signalling.Signal rtmSignal)
        {
            Signal signal = new Signal("", null, null, null, FixingTypes.foundation, null, rtmSignal, null, null);
            signal.AllocateUUID();
            return signal;
        }
    }
}
