using Models.Service;
using Models.TopoModels.Eulynx;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Services.Service
{
    public class XDocSerializeService : IXDocSerializer<Eulynx>
    {
        private String SerializeToString(Eulynx eulynx)
        {
            XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            xmlns.Add("xsi", @"http://www.w3.org/2001/XMLSchema-instance");
            xmlns.Add("rtmCommon", @"http://www.railtopomodel.org/schemas/Common");
            xmlns.Add("eurtm", @"http://www.railtopomodel.org/schemas/EULYNX_XSD");
            xmlns.Add("netEntity", @"http://www.railtopomodel.org/schemas/NetEntity");

            XmlSerializer xsSubmit = new XmlSerializer(typeof(Eulynx));
            var subReq = eulynx;
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, subReq, xmlns);
                    xml = sww.ToString(); // Your XML
                }
            }
            return xml;
        }

        public XDocument Serialize(Eulynx eulynx)
        {
            String eulynxXml = this.SerializeToString(eulynx);
            XDocument eulynxDoc = XDocument.Parse(eulynxXml);
            eulynxDoc.Declaration = new XDeclaration("1.0", "UTF-8", null);

            return eulynxDoc;
        }


    }
}
