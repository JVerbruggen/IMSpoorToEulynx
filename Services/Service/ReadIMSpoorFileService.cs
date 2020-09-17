using Models.File;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Services.Service
{
    public class ReadIMSpoorFileService : IReadFileService<IMSpoor>
    {
        private T DeserializeObject<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                return (T)serializer.Deserialize(tr);
            }
        }

        public IMSpoor Read(String filePath)
        {
            var d = XDocument.Load(filePath);
            IMSpoor imSpoor = DeserializeObject<IMSpoor>(d.ToString());

            return imSpoor;
        }
    }
}
