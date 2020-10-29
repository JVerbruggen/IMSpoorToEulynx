using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.TopoModels.IMSpoor.V1_2_3;
using Services.DependencyInjection;
using Services.DependencyInjection.Abstract;
using Services.Managers.Base;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Version = Models.TopoModels.Eulynx.EULYNX_XSD.Version;

namespace Services.Managers.Toplevel
{
    public class EulynxManager : AbstractManager<Eulynx>
    {
        public Eulynx GetEulynx(IMSpoor imSpoor)
        {
            Eulynx eulynx = new Eulynx();

            //InstanceManager.AddInstanceSupplier(new InstanceSupplier<IMSpoor>(imSpoor));

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

            //InstanceManager.AddInstanceSupplier(new InstanceSupplier<tSituation>(situation));
            InstanceManager.Singleton<IMSpoorReadingService>().GetInstance().situation = situation;

            RtmEntitiesManager rtmEntitiesManager = InstanceManager.Singleton<RtmEntitiesManager>().GetInstance();
            SignallingEntitiesManager signallingEntitiesManager = InstanceManager.Singleton<SignallingEntitiesManager>().GetInstance();

            RtmEntities rtmEntities = rtmEntitiesManager.GetRtmEntities(situation);
            SignallingEntities signallingEntities = signallingEntitiesManager.GetSignallingEntities(imSpoor);

            rtmEntities = rtmEntitiesManager.UpdateRtmEntities(rtmEntities, situation);

            eulynx.ownsRtmEntities = rtmEntities;
            eulynx.ownsSignallingEntities = signallingEntities;

            return eulynx;
        }
    }
}
