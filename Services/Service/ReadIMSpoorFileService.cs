using Models.File;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Services.Service
{
    public class ReadIMSpoorFileService : IReadFileService<Models.TopoModels.IMSpoor.V1_3_0.IMSpoor>
    {
        private T DeserializeObject<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                return (T)serializer.Deserialize(tr);
            }
        }

        public Models.TopoModels.IMSpoor.V1_3_0.IMSpoor Read(String filePath)
        {
            var d = XDocument.Load(filePath);
            Models.TopoModels.IMSpoor.V1_3_0.IMSpoor imSpoor = DeserializeObject<Models.TopoModels.IMSpoor.V1_3_0.IMSpoor>(d.ToString());

            return imSpoor;
        }
    }
}
