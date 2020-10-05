using Models.Assets;
using Models.DependencyInjection.Manager;
using Models.TopoModels.Eulynx;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Managers.Assets
{
    public class SignalManager : ItemManager<Signal1>
    {
        public Signal1[] GetSignals(Models.TopoModels.IMSpoor.V1_3_0.Signal[] imspoorSignals)
        {
            IList<Signal1> signalsConverted = new List<Signal1>();
            foreach (Models.TopoModels.IMSpoor.V1_3_0.Signal imspoorSignal in imspoorSignals)
            {
                Signal rtmSignal = new Signal(imspoorSignal);
                InstanceManager.Singleton<SignalRTMManager>().GetInstance().Register(rtmSignal);

                SignalFrameManager signalFrameManager = InstanceManager.Singleton<SignalFrameManager>().GetInstance();
                SignalFrame[] signalFrames = signalFrameManager.GetSignalFrames();
                tElementWithIDref[] signalFramesRefs = tElementWithIDref.GetTElementsWithIDref(signalFrames);

                Signal1 signal = new Signal1(imspoorSignal, rtmSignal, signalFramesRefs);
                signalsConverted.Add(signal);
            }
            return signalsConverted.ToArray();
        }

    }
}
