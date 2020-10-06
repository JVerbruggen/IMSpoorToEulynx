using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Models.TopoModels.IMSpoor.V1_3_0;
using Models.Translation;
using Services.DependencyInjection;
using Services.Managers.Toplevel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class IMSpoorToEulynxTranslationService : ITranslationService<IMSpoor, Eulynx>
    {
        public Eulynx Translate(IMSpoor imSpoor)
        {
            Eulynx eulynx = InstanceManager.Singleton<EulynxManager>().GetInstance().GetEulynx(imSpoor);

            return eulynx;
        }
    }
}
