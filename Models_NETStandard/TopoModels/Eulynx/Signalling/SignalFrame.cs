using Models.TopoModels.EULYNX.rtmCommon;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.TopoModels.EULYNX.sig
{
    public partial class SignalFrame
    {
        public SignalFrame()
        {

        }

        public SignalFrame(List<tElementWithIDref> aspects, SignalFrameTypes signalFrameType, string id)
        {
            this.hasAspect = aspects;
            this.isOfSignalFrameType = signalFrameType;
            this.id = id;
        }
    }
}
