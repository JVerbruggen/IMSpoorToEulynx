using Models.File;
using Models.Service;
using Models.TopoModels.Eulynx;
using Models.Translation;
using Services.Service;
using Services.TopoModels;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace IMSpoorToRTM
{
    public partial class Form1 : Form
    {
        private ITranslationService<IMSpoor, RailTopoModel> translationService = new XSDParseTranslationService();
        private IReadFileService<Models.TopoModels.IMSpoor.IMSpoor> imSpoorFileReadService = new ReadIMSpoorFileService();
        private ISerializer<Eulynx> eulynxSerializer = new XMLSerializeService();

        public Form1()
        {
            InitializeComponent();

            //textBox_IMSpoorXML.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textBox_IMSpoorXML.Text = @"C:\Users\jurje\OneDrive\Documenten\ProRail EULYNX IMSPOOR Collections\IMSpoor-1.3.0_Examples\IMSpoor-1.3.0-actual.xml";
        }

        private void button_chooseIMSpoorXML_Click(object sender, EventArgs e)
        {
            openFileDialog_IMSpoorXML.InitialDirectory = textBox_IMSpoorXML.Text;
            
            if(openFileDialog_IMSpoorXML.ShowDialog() == DialogResult.OK)
            {
                textBox_IMSpoorXML.Text = openFileDialog_IMSpoorXML.FileName;
            }
        }

        private void setAccessRule(string directory)
        {
            System.Security.AccessControl.DirectorySecurity sec = new DirectoryInfo(directory).GetAccessControl();
            FileSystemAccessRule accRule = new FileSystemAccessRule(Environment.UserDomainName + "\\" + Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow);
            sec.AddAccessRule(accRule);
        }

        private void button_startConversion_Click(object sender, EventArgs e)
        {
            String filePath = textBox_IMSpoorXML.Text;

            Models.TopoModels.IMSpoor.IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = new Eulynx();

            eulynx = eulynx.TranslateSingle(imSpoor);

            String eulynxXml = eulynxSerializer.Serialize(eulynx);
            XDocument eulynxDoc = XDocument.Parse(eulynxXml);
            eulynxDoc.Declaration = new XDeclaration("1.0", "UTF-8", null);

            saveFileDialog_EulynxXMLOutput.InitialDirectory = @"C:\Users\jurje\OneDrive\Documenten\Eulynxgens\EULYNX-from-IMSpoor.xml";
            if (saveFileDialog_EulynxXMLOutput.ShowDialog() == DialogResult.OK)
            {
                eulynxDoc.Save(saveFileDialog_EulynxXMLOutput.FileName);
            }
        }
    }
}
