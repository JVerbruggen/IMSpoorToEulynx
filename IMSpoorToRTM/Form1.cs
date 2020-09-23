using Models.File;
using Models.Service;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Models.Translation;
using Services.Service;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        private ITranslationService<IMSpoor, Eulynx> imspoorToEulynxTranslationService = new IMSpoorToEulynxTranslationService();
        private IReadFileService<IMSpoor> imSpoorFileReadService = new ReadIMSpoorFileService();
        private IXDocSerializer<Eulynx> eulynxSerializer = new XDocSerializeService();

        public Form1()
        {
            InitializeComponent();

            textBox_IMSpoorXML.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\IMSpoor-1.3.0-actual.xml";
            updateConversionButtonState();
        }

        private void button_chooseIMSpoorXML_Click(object sender, EventArgs e)
        {
            openFileDialog_IMSpoorXML.InitialDirectory = textBox_IMSpoorXML.Text;
            
            if(openFileDialog_IMSpoorXML.ShowDialog() == DialogResult.OK)
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

        private void button_startConversion_Click(object sender, EventArgs e)
        {
            String filePath = textBox_IMSpoorXML.Text;

            if (!File.Exists(filePath))
            {
                updateConversionButtonState();
                return;
            }

            IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            XDocument eulynxDoc = eulynxSerializer.Serialize(eulynx);

            
            saveFileDialog_EulynxXMLOutput.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\EULYNX-from-IMSpoor.xml";
            if (saveFileDialog_EulynxXMLOutput.ShowDialog() == DialogResult.OK)
            {
                eulynxDoc.Save(saveFileDialog_EulynxXMLOutput.FileName);
            }

            TopologyView topologyView = new TopologyView(eulynx);
            topologyView.Show();
        }

        private void button_languageSelect_Click(object sender, EventArgs e)
        {
            Form languageSelect = new LanguageSelect();

            languageSelect.ShowDialog();

            Control found = null;
            foreach(Control c in languageSelect.Controls)
            {
                if(c.Name == "label_chosenLanguage")
                {
                    found = c;
                    break;
                }
            }
            if (found == null) return;


            Language result = (Language)Enum.Parse(typeof(Language), found.Text);

        }
    }
}
