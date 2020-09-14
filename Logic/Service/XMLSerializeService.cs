using Models.Service;
using Models.TopoModels.Eulynx;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Services.Service
{
    public class XMLSerializeService : ISerializer<Eulynx>
    {
        public String Serialize(Eulynx eulynx)
        {
            //MethodInfo method = typeof(XmlSerializer).GetMethod("set_Mode", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            //String s = (String)method.Invoke(null, new object[] { eulynx });
            //return s;


            XmlSerializer xsSubmit = new XmlSerializer(typeof(Eulynx));
            var subReq = eulynx;
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq);
                    xml = sww.ToString(); // Your XML
                }
            }

            return xml;
        }



    }
}
