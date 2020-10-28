using Models.File;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Services.Service
{
    public class ReadXMLFileService : IReadFileService<IEnumerable<XElement>>
    {
        public XDocument doc;
        public XmlNamespaceManager NamespaceManager;

        public ReadXMLFileService(string filePath, XmlNamespaceManager namespaceManager)
        {
            Initialize(filePath, namespaceManager);
        }

        private void Initialize(string filePath, XmlNamespaceManager namespaceManager)
        {
            doc = XDocument.Load(filePath);
            NamespaceManager = namespaceManager;
        }

        /// <summary>
        /// Reads descendent path of XDocument belonging to this instance
        /// </summary>
        /// <param name="path">XPath path to find elements of</param>
        /// <returns>Elements in path</returns>
        public IEnumerable<XElement> Read(string path)
        {
            return doc.XPathSelectElements(path, NamespaceManager);
        }
    }
}
