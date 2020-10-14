using Models.File;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Services.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class ReadEulynxFileService : IReadFileService<Eulynx>
    {
        public Eulynx Read(string filePath)
        {
            XMLSerializeService xmlSerializeService = InstanceManager.Singleton<XMLSerializeService>().GetInstance();

            var d = XDocument.Load(filePath);
            Eulynx eulynx = xmlSerializeService.DeserializeObject<Eulynx>(d.ToString());

            return eulynx;
        }
    }
}
