using Models.File;
using Models.TopoModels.Eulynx.Common;
using Models.TopoModels.Eulynx.EULYNX_XSD;
using Models.TopoModels.IMSpoor.V1_3_0;
using Models.Translation;
using Services.DependencyInjection;
using Services.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        private ITranslationService<IMSpoor, Eulynx> imspoorToEulynxTranslationService = new IMSpoorToEulynxTranslationService();
        [Obsolete]
        private IReadFileService<IMSpoor> imSpoorFileReadService = new ReadIMSpoorFileService();
        private IReadFileService<Eulynx> eulynxFileReadService = new ReadEulynxFileService();
        private IReadFileService<IEnumerable<XElement>> xmlFileReadService;
        private IXDocSerializer<Eulynx> eulynxSerializer = new XDocSerializeService();

        public Form1()
        {
            InitializeComponent();

            textBox_IMSpoorXML.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\IMSpoor-1.3.0-actual.xml";
            updateConversionButtonState();

            //Signal signal = new Models.TopoModels.Eulynx.EULYNX_Signalling.Signal();
            //tElementWithIDref signalRef = signal;

            
        }

        private void button_chooseIMSpoorXML_Click(object sender, EventArgs e)
        {
            openFileDialog_IMSpoorXML.InitialDirectory = textBox_IMSpoorXML.Text;

            if (openFileDialog_IMSpoorXML.ShowDialog() == DialogResult.OK)
            {
                textBox_IMSpoorXML.Text = openFileDialog_IMSpoorXML.FileName;
                updateConversionButtonState();
            }
        }

        private void updateConversionButtonState()
        {
            String filePath = textBox_IMSpoorXML.Text;

            button_startConversion.Enabled = File.Exists(filePath);
        }

        private void saveEulynx(Eulynx eulynx)
        {
            XDocument eulynxDoc = eulynxSerializer.Serialize(eulynx);

            saveFileDialog_EulynxXMLOutput.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EULYNX-from-IMSpoor.xml";
            if (saveFileDialog_EulynxXMLOutput.ShowDialog() == DialogResult.OK)
            {
                eulynxDoc.Save(saveFileDialog_EulynxXMLOutput.FileName);
                textBox_eulynxXML.Text = saveFileDialog_EulynxXMLOutput.FileName;
            }
        }

        private void startConversionIMSpoor()
        {
            String filePath = textBox_IMSpoorXML.Text;

            if (!File.Exists(filePath))
            {
                updateConversionButtonState();
                return;
            }

            IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            saveEulynx(eulynx);
            showTopology(eulynx);
        }

        private void startConversionXElementIMSpoor()
        {
            String filePath = textBox_IMSpoorXML.Text;

            if (!File.Exists(filePath))
            {
                updateConversionButtonState();
                return;
            }

            XmlNamespaceManager namespaceManager = new XmlNamespaceManager(new NameTable());
            var dict = NamespaceProvider.GetIMSpoorNamespaces();
            foreach(string name in dict.Keys)
            {
                string @namespace = dict[name];
                namespaceManager.AddNamespace(name, @namespace);
            }

            XDocument doc = XDocument.Load(filePath);

            //xmlFileReadService = new ReadXMLFileService(filePath, namespaceManager);
            //IEnumerable<XElement> doc = xmlFileReadService.Read("./imspoor/situation");
            //var f = doc.First();
            //var imSpoor = from el in doc.Elements()
            //              select el;

            //Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            //saveEulynx(eulynx);
            //showTopology(eulynx);
        }

        private void button_startConversion_Click(object sender, EventArgs e)
        {
            startConversionIMSpoor();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showTopology(Eulynx eulynx)
        {
            TopologyView topologyView = new TopologyView(eulynx);
            topologyView.Show();
        }

        private void button_chooseEulynxXML_Click(object sender, EventArgs e)
        {
            openFileDialog_EulynxXML.InitialDirectory = textBox_IMSpoorXML.Text;

            if (openFileDialog_EulynxXML.ShowDialog() == DialogResult.OK)
            {
                textBox_eulynxXML.Text = openFileDialog_EulynxXML.FileName;
            }
        }

        private void button_loadEulynx_Click(object sender, EventArgs e)
        {
            String filePath = textBox_eulynxXML.Text;

            if (!File.Exists(filePath))
            {
                return;
            }

            Eulynx eulynx = eulynxFileReadService.Read(filePath);

            showTopology(eulynx);
        }
    }
}
