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
            this.openFileDialog_IMSpoorXML = new System.Windows.Forms.OpenFileDialog();
            this.button_chooseIMSpoorXML = new System.Windows.Forms.Button();
            this.textBox_IMSpoorXML = new System.Windows.Forms.TextBox();
            this.groupBox_IMSpoorXML = new System.Windows.Forms.GroupBox();
            this.button_startConversion = new System.Windows.Forms.Button();
            this.label_IMSpoorXMLFile = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog_EulynxXMLOutput = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_eulynxXML = new System.Windows.Forms.GroupBox();
            this.button_loadEulynx = new System.Windows.Forms.Button();
            this.button_chooseEulynxXML = new System.Windows.Forms.Button();
            this.textBox_eulynxXML = new System.Windows.Forms.TextBox();
            this.openFileDialog_EulynxXML = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_IMSpoorXML.SuspendLayout();
            this.groupBox_eulynxXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_IMSpoorXML
            // 
            this.openFileDialog_IMSpoorXML.AddExtension = false;
            this.openFileDialog_IMSpoorXML.DefaultExt = "xml";
            this.openFileDialog_IMSpoorXML.FileName = "IMSpoor-1.3.0-actual.xml";
            this.openFileDialog_IMSpoorXML.Filter = "XML files (*.xml)|*.xml";
            this.openFileDialog_IMSpoorXML.InitialDirectory = "C:\\";
            this.openFileDialog_IMSpoorXML.RestoreDirectory = true;
            this.openFileDialog_IMSpoorXML.Title = "Select IMSpoor XML file to load";
            // 
            // button_chooseIMSpoorXML
            // 
            this.button_chooseIMSpoorXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseIMSpoorXML.Location = new System.Drawing.Point(430, 46);
            this.button_chooseIMSpoorXML.Name = "button_chooseIMSpoorXML";
            this.button_chooseIMSpoorXML.Size = new System.Drawing.Size(29, 27);
            this.button_chooseIMSpoorXML.TabIndex = 0;
            this.button_chooseIMSpoorXML.Text = "...";
            this.button_chooseIMSpoorXML.UseVisualStyleBackColor = true;
            this.button_chooseIMSpoorXML.Click += new System.EventHandler(this.button_chooseIMSpoorXML_Click);
            // 
            // textBox_IMSpoorXML
            // 
            this.textBox_IMSpoorXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IMSpoorXML.Location = new System.Drawing.Point(8, 46);
            this.textBox_IMSpoorXML.Name = "textBox_IMSpoorXML";
            this.textBox_IMSpoorXML.Size = new System.Drawing.Size(416, 27);
            this.textBox_IMSpoorXML.TabIndex = 1;
            // 
            // groupBox_IMSpoorXML
            // 
            this.groupBox_IMSpoorXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_IMSpoorXML.Controls.Add(this.button_startConversion);
            this.groupBox_IMSpoorXML.Controls.Add(this.label_IMSpoorXMLFile);
            this.groupBox_IMSpoorXML.Controls.Add(this.button_chooseIMSpoorXML);
            this.groupBox_IMSpoorXML.Controls.Add(this.textBox_IMSpoorXML);
            this.groupBox_IMSpoorXML.Location = new System.Drawing.Point(11, 5);
            this.groupBox_IMSpoorXML.Name = "groupBox_IMSpoorXML";
            this.groupBox_IMSpoorXML.Size = new System.Drawing.Size(465, 125);
            this.groupBox_IMSpoorXML.TabIndex = 2;
            this.groupBox_IMSpoorXML.TabStop = false;
            this.groupBox_IMSpoorXML.Text = "IMSpoor XML";
            // 
            // button_startConversion
            // 
            this.button_startConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_startConversion.Location = new System.Drawing.Point(365, 90);
            this.button_startConversion.Name = "button_startConversion";
            this.button_startConversion.Size = new System.Drawing.Size(94, 29);
            this.button_startConversion.TabIndex = 3;
            this.button_startConversion.Text = "Convert";
            this.button_startConversion.UseVisualStyleBackColor = true;
            this.button_startConversion.Click += new System.EventHandler(this.button_startConversion_Click);
            // 
            // label_IMSpoorXMLFile
            // 
            this.label_IMSpoorXMLFile.AutoSize = true;
            this.label_IMSpoorXMLFile.Location = new System.Drawing.Point(8, 23);
            this.label_IMSpoorXMLFile.Name = "label_IMSpoorXMLFile";
            this.label_IMSpoorXMLFile.Size = new System.Drawing.Size(154, 20);
            this.label_IMSpoorXMLFile.TabIndex = 3;
            this.label_IMSpoorXMLFile.Text = "Locatie IMSpoor XML:";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(19, 136);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(457, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // saveFileDialog_EulynxXMLOutput
            // 
            this.saveFileDialog_EulynxXMLOutput.FileName = "eulynx-from-imspoor-generated.xml";
            this.saveFileDialog_EulynxXMLOutput.Filter = "XML files|*.xml";
            // 
            // groupBox_eulynxXML
            // 
            this.groupBox_eulynxXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_eulynxXML.Controls.Add(this.button_loadEulynx);
            this.groupBox_eulynxXML.Controls.Add(this.button_chooseEulynxXML);
            this.groupBox_eulynxXML.Controls.Add(this.textBox_eulynxXML);
            this.groupBox_eulynxXML.Location = new System.Drawing.Point(11, 171);
            this.groupBox_eulynxXML.Name = "groupBox_eulynxXML";
            this.groupBox_eulynxXML.Size = new System.Drawing.Size(465, 106);
            this.groupBox_eulynxXML.TabIndex = 4;
            this.groupBox_eulynxXML.TabStop = false;
            this.groupBox_eulynxXML.Text = "EULYNX XML";
            this.groupBox_eulynxXML.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_loadEulynx
            // 
            this.button_loadEulynx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_loadEulynx.Location = new System.Drawing.Point(365, 71);
            this.button_loadEulynx.Name = "button_loadEulynx";
            this.button_loadEulynx.Size = new System.Drawing.Size(94, 29);
            this.button_loadEulynx.TabIndex = 3;
            this.button_loadEulynx.Text = "Load";
            this.button_loadEulynx.UseVisualStyleBackColor = true;
            this.button_loadEulynx.Click += new System.EventHandler(this.button_loadEulynx_Click);
            // 
            // button_chooseEulynxXML
            // 
            this.button_chooseEulynxXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_chooseEulynxXML.Location = new System.Drawing.Point(430, 26);
            this.button_chooseEulynxXML.Name = "button_chooseEulynxXML";
            this.button_chooseEulynxXML.Size = new System.Drawing.Size(29, 27);
            this.button_chooseEulynxXML.TabIndex = 0;
            this.button_chooseEulynxXML.Text = "...";
            this.button_chooseEulynxXML.UseVisualStyleBackColor = true;
            this.button_chooseEulynxXML.Click += new System.EventHandler(this.button_chooseEulynxXML_Click);
            // 
            // textBox_eulynxXML
            // 
            this.textBox_eulynxXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_eulynxXML.Location = new System.Drawing.Point(8, 26);
            this.textBox_eulynxXML.Name = "textBox_eulynxXML";
            this.textBox_eulynxXML.Size = new System.Drawing.Size(416, 27);
            this.textBox_eulynxXML.TabIndex = 1;
            // 
            // openFileDialog_EulynxXML
            // 
            this.openFileDialog_EulynxXML.FileName = "openFileDialog_EulynxXML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 463);
            this.Controls.Add(this.groupBox_eulynxXML);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox_IMSpoorXML);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox_IMSpoorXML.ResumeLayout(false);
            this.groupBox_IMSpoorXML.PerformLayout();
            this.groupBox_eulynxXML.ResumeLayout(false);
            this.groupBox_eulynxXML.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox_eulynxXML;
        private System.Windows.Forms.Button button_loadEulynx;
        private System.Windows.Forms.Button button_chooseEulynxXML;
        private System.Windows.Forms.TextBox textBox_eulynxXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog_EulynxXML;
    }
}

