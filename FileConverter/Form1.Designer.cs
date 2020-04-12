namespace FileConverter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxFamilyID = new System.Windows.Forms.TextBox();
            this.textBoxVariantID = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxBuild = new System.Windows.Forms.TextBox();
            this.textBoxInfoCRC = new System.Windows.Forms.TextBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelVariant = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelBuild = new System.Windows.Forms.Label();
            this.labelCrc = new System.Windows.Forms.Label();
            this.checkBoxAddIdInfo = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(557, 81);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(557, 130);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.BackColor = System.Drawing.Color.White;
            this.textBoxOpen.Location = new System.Drawing.Point(14, 35);
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.ReadOnly = true;
            this.textBoxOpen.Size = new System.Drawing.Size(283, 20);
            this.textBoxOpen.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(557, 176);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(14, 104);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResults.Size = new System.Drawing.Size(283, 253);
            this.tbResults.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 72);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(283, 23);
            this.progressBar.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(557, 220);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxFamilyID
            // 
            this.textBoxFamilyID.Enabled = false;
            this.textBoxFamilyID.Location = new System.Drawing.Point(408, 118);
            this.textBoxFamilyID.Name = "textBoxFamilyID";
            this.textBoxFamilyID.Size = new System.Drawing.Size(80, 20);
            this.textBoxFamilyID.TabIndex = 6;
            // 
            // textBoxVariantID
            // 
            this.textBoxVariantID.Enabled = false;
            this.textBoxVariantID.Location = new System.Drawing.Point(408, 165);
            this.textBoxVariantID.Name = "textBoxVariantID";
            this.textBoxVariantID.Size = new System.Drawing.Size(80, 20);
            this.textBoxVariantID.TabIndex = 7;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Enabled = false;
            this.textBoxVersion.Location = new System.Drawing.Point(408, 212);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(80, 20);
            this.textBoxVersion.TabIndex = 8;
            // 
            // textBoxBuild
            // 
            this.textBoxBuild.Enabled = false;
            this.textBoxBuild.Location = new System.Drawing.Point(408, 260);
            this.textBoxBuild.Name = "textBoxBuild";
            this.textBoxBuild.Size = new System.Drawing.Size(80, 20);
            this.textBoxBuild.TabIndex = 9;
            // 
            // textBoxInfoCRC
            // 
            this.textBoxInfoCRC.Enabled = false;
            this.textBoxInfoCRC.Location = new System.Drawing.Point(408, 305);
            this.textBoxInfoCRC.Name = "textBoxInfoCRC";
            this.textBoxInfoCRC.Size = new System.Drawing.Size(80, 20);
            this.textBoxInfoCRC.TabIndex = 10;
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFamily.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelFamily.Location = new System.Drawing.Point(329, 121);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(42, 13);
            this.labelFamily.TabIndex = 11;
            this.labelFamily.Text = "Family: ";
            this.labelFamily.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVariant
            // 
            this.labelVariant.AutoSize = true;
            this.labelVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVariant.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelVariant.Location = new System.Drawing.Point(329, 170);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(43, 13);
            this.labelVariant.TabIndex = 12;
            this.labelVariant.Text = "Variant:";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelVersion.Location = new System.Drawing.Point(329, 216);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(66, 13);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version:       ";
            // 
            // labelBuild
            // 
            this.labelBuild.AutoSize = true;
            this.labelBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBuild.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelBuild.Location = new System.Drawing.Point(329, 263);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(66, 13);
            this.labelBuild.TabIndex = 14;
            this.labelBuild.Text = "Build:           ";
            this.labelBuild.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelCrc
            // 
            this.labelCrc.AutoSize = true;
            this.labelCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCrc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelCrc.Location = new System.Drawing.Point(329, 309);
            this.labelCrc.Name = "labelCrc";
            this.labelCrc.Size = new System.Drawing.Size(65, 13);
            this.labelCrc.TabIndex = 15;
            this.labelCrc.Text = "Info CRC:    ";
            // 
            // checkBoxAddIdInfo
            // 
            this.checkBoxAddIdInfo.AutoSize = true;
            this.checkBoxAddIdInfo.Location = new System.Drawing.Point(332, 75);
            this.checkBoxAddIdInfo.Name = "checkBoxAddIdInfo";
            this.checkBoxAddIdInfo.Size = new System.Drawing.Size(211, 17);
            this.checkBoxAddIdInfo.TabIndex = 16;
            this.checkBoxAddIdInfo.Text = "add device ID information into the array";
            this.checkBoxAddIdInfo.UseVisualStyleBackColor = true;
            this.checkBoxAddIdInfo.CheckedChanged += new System.EventHandler(this.checkBoxAddIdInfo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(495, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "(1 byte)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(494, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "(1 byte)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(495, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(1 byte)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(494, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "(1 byte)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(494, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "(3 bytes)";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(557, 302);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 22;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ENC File:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(389, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "0x";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(389, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "0x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(389, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "0x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(389, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "0x";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(389, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "0x";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 367);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxAddIdInfo);
            this.Controls.Add(this.labelCrc);
            this.Controls.Add(this.labelBuild);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelVariant);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.textBoxInfoCRC);
            this.Controls.Add(this.textBoxBuild);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.textBoxVariantID);
            this.Controls.Add(this.textBoxFamilyID);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.textBoxOpen);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENC2Array Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxFamilyID;
        private System.Windows.Forms.TextBox textBoxVariantID;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxBuild;
        private System.Windows.Forms.TextBox textBoxInfoCRC;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelBuild;
        private System.Windows.Forms.Label labelCrc;
        private System.Windows.Forms.CheckBox checkBoxAddIdInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

