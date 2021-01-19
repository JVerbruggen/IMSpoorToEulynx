using Models.TopoModels.EULYNX.sig;
using Services.Extensions;
using Services.Factory.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Factory.Assets
{
    public class SignalFactory : Factory<Signal>
    {
        public Signal GetSignal(Models.TopoModels.EULYNX.rtmSig.Signal rtmSignal)
        {
            Signal signal = new Signal(null, null, FixingTypes.foundation, null, rtmSignal, null, null);
            //Signal signal = new Signal("", null, null, null, FixingTypes.foundation, null, rtmSignal, null, null);
            signal.AllocateUUID();
            return signal;
        }
    }
}
