using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_Signalling;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public class SignalFrameManager : ItemManager<SignalFrame>
    {

        public SignalFrame[] GetSignalFrames()
        {
            IList<tElementWithIDref> aspects = new List<tElementWithIDref>();
            SignalFrameTypes signalFrameType = SignalFrameTypes.main;

            string uuid = UUIDService.NewFakeUUID(aspects.ToString() + signalFrameType.ToString());
            SignalFrame signalFrame = new SignalFrame(aspects.ToArray(), signalFrameType, uuid);

            List<SignalFrame> signalFrames = new List<SignalFrame>();
            signalFrames.Add(signalFrame);

            return signalFrames.ToArray();
        }

    }
}
