using Models.File;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Services.DependencyInjection;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Services.Service
{
    public class ReadIMSpoorFileService : IReadFileService<Models.TopoModels.IMSpoor.V1_2_3.IMSpoor>
    {
        public Models.TopoModels.IMSpoor.V1_2_3.IMSpoor Read(String filePath)
        {
            XMLSerializeService xmlSerializeService = InstanceManager.Singleton<XMLSerializeService>().GetInstance();

            var d = XDocument.Load(filePath);
            Models.TopoModels.IMSpoor.V1_2_3.IMSpoor imSpoor = xmlSerializeService.DeserializeObject<Models.TopoModels.IMSpoor.V1_2_3.IMSpoor>(d.ToString());

            return imSpoor;
        }
    }
}
