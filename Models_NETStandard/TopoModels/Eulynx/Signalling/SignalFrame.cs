using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx
{
    public partial class SignalFrame
    {
        public SignalFrame()
        {

        }

        public SignalFrame(tElementWithIDref[] aspects, SignalFrameTypes signalFrameType, string uuid)
        {
            this.hasAspect = aspects;
            this.isOfSignalFrameType = signalFrameType;
            this.uuid = uuid;
        }
    }
}
