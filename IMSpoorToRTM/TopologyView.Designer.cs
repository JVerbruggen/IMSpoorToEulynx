namespace FormsApp
{
    partial class TopologyView
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
            this.groupBox_drawing = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_includePassedElements = new System.Windows.Forms.CheckBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_possiblePaths = new System.Windows.Forms.Button();
            this.button_findPathSubmit = new System.Windows.Forms.Button();
            this.comboBox_pathFindEnd = new System.Windows.Forms.ComboBox();
            this.comboBox_pathFindStart = new System.Windows.Forms.ComboBox();
            this.listBox_content = new System.Windows.Forms.ListBox();
            this.button_netEntities = new System.Windows.Forms.Button();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.button_details = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_drawing
            // 
            this.groupBox_drawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_drawing.Location = new System.Drawing.Point(12, 12);
            this.groupBox_drawing.Name = "groupBox_drawing";
            this.groupBox_drawing.Size = new System.Drawing.Size(1162, 297);
            this.groupBox_drawing.TabIndex = 0;
            this.groupBox_drawing.TabStop = false;
            this.groupBox_drawing.Text = "Overview";
            this.groupBox_drawing.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_drawing_Paint);
            this.groupBox_drawing.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBox_includePassedElements);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.button_possiblePaths);
            this.groupBox1.Controls.Add(this.button_findPathSubmit);
            this.groupBox1.Controls.Add(this.comboBox_pathFindEnd);
            this.groupBox1.Controls.Add(this.comboBox_pathFindStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path finder";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // checkBox_includePassedElements
            // 
            this.checkBox_includePassedElements.AutoSize = true;
            this.checkBox_includePassedElements.Location = new System.Drawing.Point(6, 118);
            this.checkBox_includePassedElements.Name = "checkBox_includePassedElements";
            this.checkBox_includePassedElements.Size = new System.Drawing.Size(193, 24);
            this.checkBox_includePassedElements.TabIndex = 5;
            this.checkBox_includePassedElements.Text = "Include passed elements";
            this.checkBox_includePassedElements.UseVisualStyleBackColor = true;
            // 
            // button_reset
            // 
            this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_reset.Location = new System.Drawing.Point(140, 148);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(56, 29);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_possiblePaths
            // 
            this.button_possiblePaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_possiblePaths.Location = new System.Drawing.Point(6, 148);
            this.button_possiblePaths.Name = "button_possiblePaths";
            this.button_possiblePaths.Size = new System.Drawing.Size(128, 29);
            this.button_possiblePaths.TabIndex = 3;
            this.button_possiblePaths.Text = "Possible paths";
            this.button_possiblePaths.UseVisualStyleBackColor = true;
            this.button_possiblePaths.Click += new System.EventHandler(this.button_possiblePaths_Click);
            // 
            // button_findPathSubmit
            // 
            this.button_findPathSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_findPathSubmit.Location = new System.Drawing.Point(332, 148);
            this.button_findPathSubmit.Name = "button_findPathSubmit";
            this.button_findPathSubmit.Size = new System.Drawing.Size(94, 29);
            this.button_findPathSubmit.TabIndex = 3;
            this.button_findPathSubmit.Text = "Find path";
            this.button_findPathSubmit.UseVisualStyleBackColor = true;
            this.button_findPathSubmit.Click += new System.EventHandler(this.button_findPathSubmit_Click);
            // 
            // comboBox_pathFindEnd
            // 
            this.comboBox_pathFindEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_pathFindEnd.FormattingEnabled = true;
            this.comboBox_pathFindEnd.Location = new System.Drawing.Point(6, 60);
            this.comboBox_pathFindEnd.Name = "comboBox_pathFindEnd";
            this.comboBox_pathFindEnd.Size = new System.Drawing.Size(420, 28);
            this.comboBox_pathFindEnd.TabIndex = 2;
            // 
            // comboBox_pathFindStart
            // 
            this.comboBox_pathFindStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_pathFindStart.FormattingEnabled = true;
            this.comboBox_pathFindStart.Location = new System.Drawing.Point(6, 26);
            this.comboBox_pathFindStart.Name = "comboBox_pathFindStart";
            this.comboBox_pathFindStart.Size = new System.Drawing.Size(420, 28);
            this.comboBox_pathFindStart.TabIndex = 2;
            // 
            // listBox_content
            // 
            this.listBox_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_content.FormattingEnabled = true;
            this.listBox_content.ItemHeight = 20;
            this.listBox_content.Location = new System.Drawing.Point(6, 26);
            this.listBox_content.Name = "listBox_content";
            this.listBox_content.Size = new System.Drawing.Size(428, 144);
            this.listBox_content.TabIndex = 2;
            // 
            // button_netEntities
            // 
            this.button_netEntities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_netEntities.Location = new System.Drawing.Point(440, 59);
            this.button_netEntities.Name = "button_netEntities";
            this.button_netEntities.Size = new System.Drawing.Size(127, 29);
            this.button_netEntities.TabIndex = 3;
            this.button_netEntities.Text = "Net entities";
            this.button_netEntities.UseVisualStyleBackColor = true;
            this.button_netEntities.Click += new System.EventHandler(this.button_netEntities_Click);
            // 
            // groupBox_info
            // 
            this.groupBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_info.Controls.Add(this.button_details);
            this.groupBox_info.Controls.Add(this.listBox_content);
            this.groupBox_info.Controls.Add(this.button_netEntities);
            this.groupBox_info.Location = new System.Drawing.Point(450, 315);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(573, 183);
            this.groupBox_info.TabIndex = 4;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // button_details
            // 
            this.button_details.Location = new System.Drawing.Point(440, 26);
            this.button_details.Name = "button_details";
            this.button_details.Size = new System.Drawing.Size(127, 29);
            this.button_details.TabIndex = 4;
            this.button_details.Text = "Details";
            this.button_details.UseVisualStyleBackColor = true;
            this.button_details.Click += new System.EventHandler(this.button_details_Click);
            // 
            // TopologyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 510);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_drawing);
            this.Name = "TopologyView";
            this.Text = "Topology View";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_drawing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_findPathSubmit;
        private System.Windows.Forms.ComboBox comboBox_pathFindEnd;
        private System.Windows.Forms.ComboBox comboBox_pathFindStart;
        private System.Windows.Forms.ListBox listBox_content;
        private System.Windows.Forms.Button button_netEntities;
        private System.Windows.Forms.Button button_possiblePaths;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Button button_details;
        private System.Windows.Forms.CheckBox checkBox_includePassedElements;
    }
}