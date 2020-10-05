using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class Signal1
    {
        public Signal1()
        {

        }

        public Signal1(IMSpoor.V1_3_0.Signal imspoorSignal, TopoModels.Eulynx.Signal rtmSignal, tElementWithIDref[] signalFrames)
        {
            this.uuid = imspoorSignal.puic;
            this.refersToRtmSignal = new tElementWithIDref(rtmSignal.uuid);
            this.hasSignalFrame = signalFrames;
        }
    }
}
