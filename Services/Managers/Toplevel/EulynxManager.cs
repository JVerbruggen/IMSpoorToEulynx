using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor.V1_3_0;
using Services.DependencyInjection;
using Services.DependencyInjection.Abstract;
using Services.Managers.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Version = Models.TopoModels.Eulynx.Version;

namespace Services.Managers.Toplevel
{
    public class EulynxManager : Manager<Eulynx>
    {
        public Eulynx TranslateSingle(IMSpoor imSpoor)
        {
            Eulynx eulynx = new Eulynx();

            InstanceManager.AddInstanceSupplier(new InstanceSupplier<IMSpoor>(imSpoor));

            object item = imSpoor.Item;
            String version = imSpoor.imxVersion;

            if (item == null) return null;

            Version v = InstanceManager.Singleton<VersionManager>().GetInstance().GetVersion(imSpoor);
            eulynx.isReleaseVersion = v;
            tSituation situation;

            if (item is tSituation)
            {
                situation = (tSituation)item;
            }
            else
            {
                Project project = (Project)item;
                situation = project.InitialSituation;
            }

            InstanceManager.AddInstanceSupplier(new InstanceSupplier<tSituation>(situation));

            RtmEntities rtmEntities = InstanceManager.Singleton<RtmEntitiesManager>().GetInstance().GetRtmEntities(situation);
            SignallingEntities signallingEntities = InstanceManager.Singleton<SignallingEntitiesManager>().GetInstance().GetSignallingEntities(imSpoor);

            eulynx.ownsRtmEntities = rtmEntities;
            eulynx.ownsSignallingEntities = signallingEntities;

            return eulynx;
        }
    }
}
