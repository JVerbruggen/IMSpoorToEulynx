using Models.TopoModels.Eulynx.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.Eulynx.EULYNX_Signalling
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
