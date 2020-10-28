using Models.TopoModels.Eulynx.EULYNX_XSD;
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
        private XmlSerializerNamespaces GetNamespaces()
        {
            XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
            var dict = NamespaceProvider.GetEulynxNamespaces();

            foreach (string name in dict.Keys)
            {
                string @namespace = dict[name];
                xmlns.Add(name, @namespace);
            }
            //xmlns.Add("xsi", @"http://www.w3.org/2001/XMLSchema-instance");
            //xmlns.Add("rtmCommon", @"http://www.railtopomodel.org/schemas/Common");
            //xmlns.Add("rtmNE", @"http://www.railtopomodel.org/schemas/NetEntity");
            //xmlns.Add("rtmSig", @"http://www.railtopomodel.org/schemas/Signalling");
            //xmlns.Add("base", @"http://www.railtopomodel.org/schemas/EULYNX_XSD");
            //xmlns.Add("eurtm", @"http://www.railtopomodel.org/schemas/EULYNX_XSD");
            //xmlns.Add("signalling", @"http://www.railtopomodel.org/schemas/EULYNX_Signalling");

            return xmlns;
        }

        private XmlWriterSettings GetWriterSettings()
        {
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;

            return xmlWriterSettings;
        }


        private String SerializeToString(Eulynx eulynx)
        {
            XmlSerializerNamespaces xmlns = GetNamespaces();
            XmlWriterSettings writerSettings = GetWriterSettings();

            XmlSerializer serializer = new XmlSerializer(typeof(Eulynx));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww, writerSettings))
                {
                    serializer.Serialize(writer, eulynx, xmlns);
                    xml = sww.GetStringBuilder().ToString();
                }
            }
            return xml;
        }

        private String SerializeToFile(Eulynx eulynx, string path)
        {
            XmlSerializerNamespaces xmlns = GetNamespaces();
            XmlWriterSettings writerSettings = GetWriterSettings();

            XmlSerializer serializer = new XmlSerializer(typeof(Eulynx));
            var xml = "";

            using (XmlWriter writer = XmlWriter.Create(path, writerSettings))
            {
                serializer.Serialize(writer, eulynx, xmlns);
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

        public void Serialize(Eulynx eulynx, string path)
        {
            SerializeToFile(eulynx, path);
        }
    }
}
