namespace FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog_IMSpoorXML = new System.Windows.Forms.OpenFileDialog();
            this.button_chooseIMSpoorXML = new System.Windows.Forms.Button();
            this.textBox_IMSpoorXML = new System.Windows.Forms.TextBox();
            this.groupBox_IMSpoorXML = new System.Windows.Forms.GroupBox();
            this.button_startConversion = new System.Windows.Forms.Button();
            this.label_IMSpoorXMLFile = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog_EulynxXMLOutput = new System.Windows.Forms.SaveFileDialog();
            this.button_languageSelect = new System.Windows.Forms.Button();
            this.groupBox_IMSpoorXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_IMSpoorXML
            // 
            this.openFileDialog_IMSpoorXML.AddExtension = false;
            this.openFileDialog_IMSpoorXML.DefaultExt = "xml";
            this.openFileDialog_IMSpoorXML.FileName = "IMSpoor-1.3.0-actual.xml";
            resources.ApplyResources(this.openFileDialog_IMSpoorXML, "openFileDialog_IMSpoorXML");
            this.openFileDialog_IMSpoorXML.InitialDirectory = "C:\\";
            this.openFileDialog_IMSpoorXML.RestoreDirectory = true;
            // 
            // button_chooseIMSpoorXML
            // 
            resources.ApplyResources(this.button_chooseIMSpoorXML, "button_chooseIMSpoorXML");
            this.button_chooseIMSpoorXML.Name = "button_chooseIMSpoorXML";
            this.button_chooseIMSpoorXML.UseVisualStyleBackColor = true;
            this.button_chooseIMSpoorXML.Click += new System.EventHandler(this.button_chooseIMSpoorXML_Click);
            // 
            // textBox_IMSpoorXML
            // 
            resources.ApplyResources(this.textBox_IMSpoorXML, "textBox_IMSpoorXML");
            this.textBox_IMSpoorXML.Name = "textBox_IMSpoorXML";
            // 
            // groupBox_IMSpoorXML
            // 
            resources.ApplyResources(this.groupBox_IMSpoorXML, "groupBox_IMSpoorXML");
            this.groupBox_IMSpoorXML.Controls.Add(this.button_startConversion);
            this.groupBox_IMSpoorXML.Controls.Add(this.label_IMSpoorXMLFile);
            this.groupBox_IMSpoorXML.Controls.Add(this.button_chooseIMSpoorXML);
            this.groupBox_IMSpoorXML.Controls.Add(this.textBox_IMSpoorXML);
            this.groupBox_IMSpoorXML.Name = "groupBox_IMSpoorXML";
            this.groupBox_IMSpoorXML.TabStop = false;
            // 
            // button_startConversion
            // 
            resources.ApplyResources(this.button_startConversion, "button_startConversion");
            this.button_startConversion.Name = "button_startConversion";
            this.button_startConversion.UseVisualStyleBackColor = true;
            this.button_startConversion.Click += new System.EventHandler(this.button_startConversion_Click);
            // 
            // label_IMSpoorXMLFile
            // 
            resources.ApplyResources(this.label_IMSpoorXMLFile, "label_IMSpoorXMLFile");
            this.label_IMSpoorXMLFile.Name = "label_IMSpoorXMLFile";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // saveFileDialog_EulynxXMLOutput
            // 
            this.saveFileDialog_EulynxXMLOutput.FileName = "eulynx-from-imspoor-generated.xml";
            resources.ApplyResources(this.saveFileDialog_EulynxXMLOutput, "saveFileDialog_EulynxXMLOutput");
            // 
            // button_languageSelect
            // 
            resources.ApplyResources(this.button_languageSelect, "button_languageSelect");
            this.button_languageSelect.Name = "button_languageSelect";
            this.button_languageSelect.UseVisualStyleBackColor = true;
            this.button_languageSelect.Click += new System.EventHandler(this.button_languageSelect_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_languageSelect);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox_IMSpoorXML);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox_IMSpoorXML.ResumeLayout(false);
            this.groupBox_IMSpoorXML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_IMSpoorXML;
        private System.Windows.Forms.Button button_chooseIMSpoorXML;
        private System.Windows.Forms.TextBox textBox_IMSpoorXML;
        private System.Windows.Forms.GroupBox groupBox_IMSpoorXML;
        private System.Windows.Forms.Label label_IMSpoorXMLFile;
        private System.Windows.Forms.Button button_startConversion;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_EulynxXMLOutput;
        private System.Windows.Forms.Button button_languageSelect;
    }
}

