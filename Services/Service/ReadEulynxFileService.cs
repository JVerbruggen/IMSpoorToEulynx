using Models.File;
using Models.TopoModels.EULYNX.dp;
using Services.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Services.Service
{
    public class ReadEulynxFileService : IReadFileService<EulynxDataPrep>
    {
        public EulynxDataPrep Read(string filePath)
        {
            XMLSerializeService xmlSerializeService = InstanceManager.Singleton<XMLSerializeService>().GetInstance();

            var d = XDocument.Load(filePath);
            EulynxDataPrep eulynx = xmlSerializeService.DeserializeObject<EulynxDataPrep>(d.ToString());

            return eulynx;
        }
    }
}
