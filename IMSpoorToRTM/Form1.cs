using Logic.Managers;
using Models.Translation;
using Services.TopoModels;
using System;
using System.Windows.Forms;

namespace IMSpoorToRTM
{
    public partial class Form1 : Form
    {
        private ITranslationService<IMSpoor, RailTopoModel> translationService = new TranslationService();

        public Form1()
        {
            InitializeComponent();

            textBox_IMSpoorXML.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void button_chooseIMSpoorXML_Click(object sender, EventArgs e)
        {
            openFileDialog_IMSpoorXML.InitialDirectory = textBox_IMSpoorXML.Text;
            
            if(openFileDialog_IMSpoorXML.ShowDialog() == DialogResult.OK)
            {
                textBox_IMSpoorXML.Text = openFileDialog_IMSpoorXML.FileName;
            }
        }

        private void button_startConversion_Click(object sender, EventArgs e)
        {
            RailTopoModel rtm = translationService.Translate(imSpoorModel);
        }
    }
}
