namespace IMSpoorToRTM
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
            this.groupBox_IMSpoorXML.SuspendLayout();
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
            this.button_chooseIMSpoorXML.Location = new System.Drawing.Point(328, 46);
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
            this.textBox_IMSpoorXML.Size = new System.Drawing.Size(314, 27);
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
            this.groupBox_IMSpoorXML.Size = new System.Drawing.Size(363, 125);
            this.groupBox_IMSpoorXML.TabIndex = 2;
            this.groupBox_IMSpoorXML.TabStop = false;
            this.groupBox_IMSpoorXML.Text = "IMSpoor XML";
            // 
            // button_startConversion
            // 
            this.button_startConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_startConversion.Location = new System.Drawing.Point(263, 90);
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
            this.progressBar1.Size = new System.Drawing.Size(355, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 369);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox_IMSpoorXML);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

