using Models.TopoModels.EULYNX.dp;
using Models.TopoModels.IMSpoor.V1_2_3;
using Models.Translation;
using Services.DependencyInjection;
using Services.Managers.Toplevel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class IMSpoor1_2_3ToEulynxTranslationService : ITranslationService<IMSpoor, EulynxDataPrep>
    {
        public EulynxDataPrep Translate(IMSpoor imSpoor)
        {
            EulynxDataPrep eulynx = InstanceManager.Singleton<EulynxManager>().GetInstance().GetEulynx(imSpoor);
            InstanceManager.Singleton(eulynx);

            return eulynx;
        }
    }
}
