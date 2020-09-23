using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class LanguageSelect : Form
    {
        public LanguageSelect()
        {
            InitializeComponent();
        }

        private void button_languageDefault_Click(object sender, EventArgs e)
        {
            label_chosenLanguage.Text = Language.DEFAULT.ToString();
        }

        private void button_languageDutch_Click(object sender, EventArgs e)
        {
            label_chosenLanguage.Text = Language.DUTCH.ToString();
        }
    }
}
