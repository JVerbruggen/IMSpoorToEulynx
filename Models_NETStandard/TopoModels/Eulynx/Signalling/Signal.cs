using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
{
    public partial class Signal
    {
        public Signal()
        {

        }

        public Signal(IMSpoor.V1_3_0.Signal imspoorSignal, Signalling.Signal rtmSignal, tElementWithIDref[] signalFrames)
        {
            this.uuid = imspoorSignal.puic;
            this.refersToRtmSignal = new tElementWithIDref(rtmSignal.uuid);
            this.hasSignalFrame = signalFrames;
        }
    }
}
