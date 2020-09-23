namespace FormsApp
{
    partial class LanguageSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_languageDefault = new System.Windows.Forms.Button();
            this.button_languageDutch = new System.Windows.Forms.Button();
            this.label_chosenLanguage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_languageDefault
            // 
            this.button_languageDefault.Location = new System.Drawing.Point(12, 12);
            this.button_languageDefault.Name = "button_languageDefault";
            this.button_languageDefault.Size = new System.Drawing.Size(94, 29);
            this.button_languageDefault.TabIndex = 0;
            this.button_languageDefault.Text = "English";
            this.button_languageDefault.UseVisualStyleBackColor = true;
            this.button_languageDefault.Click += new System.EventHandler(this.button_languageDefault_Click);
            // 
            // button_languageDutch
            // 
            this.button_languageDutch.Location = new System.Drawing.Point(112, 12);
            this.button_languageDutch.Name = "button_languageDutch";
            this.button_languageDutch.Size = new System.Drawing.Size(94, 29);
            this.button_languageDutch.TabIndex = 0;
            this.button_languageDutch.Text = "Dutch";
            this.button_languageDutch.UseVisualStyleBackColor = true;
            this.button_languageDutch.Click += new System.EventHandler(this.button_languageDutch_Click);
            // 
            // label_chosenLanguage
            // 
            this.label_chosenLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_chosenLanguage.Location = new System.Drawing.Point(218, 98);
            this.label_chosenLanguage.Name = "label_chosenLanguage";
            this.label_chosenLanguage.Size = new System.Drawing.Size(125, 29);
            this.label_chosenLanguage.TabIndex = 1;
            // 
            // LanguageSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 136);
            this.ControlBox = false;
            this.Controls.Add(this.label_chosenLanguage);
            this.Controls.Add(this.button_languageDutch);
            this.Controls.Add(this.button_languageDefault);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LanguageSelect";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LanguageSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_languageDefault;
        private System.Windows.Forms.Button button_languageDutch;
        private System.Windows.Forms.Label label_chosenLanguage;
    }
}