namespace VRADFix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFaceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonBrowseBsp = new System.Windows.Forms.Button();
            this.textBoxBsp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxG = new System.Windows.Forms.CheckBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.buttonUnload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHDR = new System.Windows.Forms.RadioButton();
            this.radioButtonLDR = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "bsp files (*.bsp)|*bsp";
            // 
            // textBoxFaceID
            // 
            this.textBoxFaceID.Location = new System.Drawing.Point(0, 44);
            this.textBoxFaceID.Name = "textBoxFaceID";
            this.textBoxFaceID.Size = new System.Drawing.Size(93, 20);
            this.textBoxFaceID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FaceId:";
            // 
            // buttonLoad
            // 
            this.helpProvider1.SetHelpKeyword(this.buttonLoad, "hey");
            this.buttonLoad.Location = new System.Drawing.Point(101, 42);
            this.buttonLoad.Name = "buttonLoad";
            this.helpProvider1.SetShowHelp(this.buttonLoad, true);
            this.buttonLoad.Size = new System.Drawing.Size(103, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load lightmap!";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonBrowseBsp
            // 
            this.buttonBrowseBsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowseBsp.Location = new System.Drawing.Point(0, 5);
            this.buttonBrowseBsp.Name = "buttonBrowseBsp";
            this.buttonBrowseBsp.Size = new System.Drawing.Size(81, 23);
            this.buttonBrowseBsp.TabIndex = 1;
            this.buttonBrowseBsp.Text = "browse";
            this.buttonBrowseBsp.UseVisualStyleBackColor = true;
            this.buttonBrowseBsp.Click += new System.EventHandler(this.buttonBrowseBsp_Click);
            // 
            // textBoxBsp
            // 
            this.textBoxBsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBsp.Location = new System.Drawing.Point(0, 10);
            this.textBoxBsp.Name = "textBoxBsp";
            this.textBoxBsp.Size = new System.Drawing.Size(505, 20);
            this.textBoxBsp.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bsp:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUpdate.Location = new System.Drawing.Point(657, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 24);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Apply";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxE);
            this.groupBox1.Controls.Add(this.checkBoxB);
            this.groupBox1.Controls.Add(this.checkBoxG);
            this.groupBox1.Controls.Add(this.checkBoxR);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(91, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color mode";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(6, 65);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(33, 17);
            this.checkBoxE.TabIndex = 0;
            this.checkBoxE.Text = "E";
            this.checkBoxE.UseVisualStyleBackColor = true;
            this.checkBoxE.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Checked = true;
            this.checkBoxB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxB.Location = new System.Drawing.Point(6, 50);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(33, 17);
            this.checkBoxB.TabIndex = 0;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxG
            // 
            this.checkBoxG.AutoSize = true;
            this.checkBoxG.Checked = true;
            this.checkBoxG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxG.Location = new System.Drawing.Point(6, 35);
            this.checkBoxG.Name = "checkBoxG";
            this.checkBoxG.Size = new System.Drawing.Size(34, 17);
            this.checkBoxG.TabIndex = 0;
            this.checkBoxG.Text = "G";
            this.checkBoxG.UseVisualStyleBackColor = true;
            this.checkBoxG.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(6, 20);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(34, 17);
            this.checkBoxR.TabIndex = 0;
            this.checkBoxR.Text = "R";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // buttonUnload
            // 
            this.buttonUnload.Location = new System.Drawing.Point(211, 42);
            this.buttonUnload.Name = "buttonUnload";
            this.buttonUnload.Size = new System.Drawing.Size(59, 23);
            this.buttonUnload.TabIndex = 8;
            this.buttonUnload.Text = "Unload";
            this.buttonUnload.UseVisualStyleBackColor = true;
            this.buttonUnload.Click += new System.EventHandler(this.buttonUnload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHDR);
            this.groupBox2.Controls.Add(this.radioButtonLDR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 55);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light mode";
            // 
            // radioButtonHDR
            // 
            this.radioButtonHDR.AutoSize = true;
            this.radioButtonHDR.Location = new System.Drawing.Point(7, 33);
            this.radioButtonHDR.Name = "radioButtonHDR";
            this.radioButtonHDR.Size = new System.Drawing.Size(49, 17);
            this.radioButtonHDR.TabIndex = 1;
            this.radioButtonHDR.Text = "HDR";
            this.radioButtonHDR.UseVisualStyleBackColor = true;
            this.radioButtonHDR.CheckedChanged += new System.EventHandler(this.radioButtonHDR_CheckedChanged);
            // 
            // radioButtonLDR
            // 
            this.radioButtonLDR.AutoSize = true;
            this.radioButtonLDR.Checked = true;
            this.radioButtonLDR.Location = new System.Drawing.Point(7, 17);
            this.radioButtonLDR.Name = "radioButtonLDR";
            this.radioButtonLDR.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLDR.TabIndex = 0;
            this.radioButtonLDR.TabStop = true;
            this.radioButtonLDR.Text = "LDR";
            this.radioButtonLDR.UseVisualStyleBackColor = true;
            this.radioButtonLDR.CheckedChanged += new System.EventHandler(this.radioButtonLDR_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(10, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(722, 404);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(742, 94);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel2.Size = new System.Drawing.Size(742, 414);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonUpdate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 508);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 3, 10, 8);
            this.panel3.Size = new System.Drawing.Size(742, 35);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 543);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(568, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel5.Size = new System.Drawing.Size(174, 94);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonBrowseBsp);
            this.panel6.Controls.Add(this.groupBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel6.Size = new System.Drawing.Size(81, 88);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(10, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(49, 94);
            this.panel7.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBoxBsp);
            this.panel8.Controls.Add(this.textBoxFaceID);
            this.panel8.Controls.Add(this.buttonLoad);
            this.panel8.Controls.Add(this.buttonUnload);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(59, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 10, 4, 10);
            this.panel8.Size = new System.Drawing.Size(509, 94);
            this.panel8.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 543);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "VRADFix v0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFaceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonBrowseBsp;
        private System.Windows.Forms.TextBox textBoxBsp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxG;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.Button buttonUnload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonHDR;
        private System.Windows.Forms.RadioButton radioButtonLDR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}

