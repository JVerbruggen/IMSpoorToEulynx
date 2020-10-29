using Models.Translation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Services.Service
{
    public class XMLSerializeService : IService
    {
        public T DeserializeObject<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var tr = new StringReader(xml))
            {
                T s = default(T);
                try
                {
                    s = (T)serializer.Deserialize(tr);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return s;
            }
        }
    }
}
