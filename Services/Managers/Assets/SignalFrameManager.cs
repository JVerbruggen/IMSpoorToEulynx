using Models.TopoModels.Eulynx;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Managers.Assets
{
    public class SignalFrameManager : ItemManager<SignalFrame>
    {

        public SignalFrame[] GetSignalFrames()
        {
            tElementWithIDref[] aspects = new tElementWithIDref[] { };
            SignalFrameTypes signalFrameType = SignalFrameTypes.main;

            string uuid = UUIDService.NewFakeUUID(aspects.ToString() + signalFrameType.ToString());
            SignalFrame signalFrame = new SignalFrame(aspects, signalFrameType, uuid);

            return new SignalFrame[] { signalFrame };
        }

    }
}
