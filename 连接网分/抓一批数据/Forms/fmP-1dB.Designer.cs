namespace 抓一批数据.Forms
{
    partial class fmP_1dB
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
            this.lblRsSg = new System.Windows.Forms.Label();
            this.lblRsSa = new System.Windows.Forms.Label();
            this.tbxSgIp = new System.Windows.Forms.TextBox();
            this.tbxSaIp = new System.Windows.Forms.TextBox();
            this.btnConnSg = new System.Windows.Forms.Button();
            this.btnConnSa = new System.Windows.Forms.Button();
            this.lblStartPower = new System.Windows.Forms.Label();
            this.tbxStartPower = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbxCalDiagram = new System.Windows.Forms.PictureBox();
            this.btnStartCal = new System.Windows.Forms.Button();
            this.btnSkipCal = new System.Windows.Forms.Button();
            this.lblStopPower = new System.Windows.Forms.Label();
            this.tbxStopPower = new System.Windows.Forms.TextBox();
            this.ckbxOneTimeMode = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbxCalFrequency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRsSg
            // 
            this.lblRsSg.AutoSize = true;
            this.lblRsSg.Location = new System.Drawing.Point(13, 14);
            this.lblRsSg.Name = "lblRsSg";
            this.lblRsSg.Size = new System.Drawing.Size(83, 13);
            this.lblRsSg.TabIndex = 0;
            this.lblRsSg.Text = "SignalGenerator";
            // 
            // lblRsSa
            // 
            this.lblRsSa.AutoSize = true;
            this.lblRsSa.Location = new System.Drawing.Point(122, 14);
            this.lblRsSa.Name = "lblRsSa";
            this.lblRsSa.Size = new System.Drawing.Size(76, 13);
            this.lblRsSa.TabIndex = 1;
            this.lblRsSa.Text = "SignalAnalyzer";
            // 
            // tbxSgIp
            // 
            this.tbxSgIp.Location = new System.Drawing.Point(16, 30);
            this.tbxSgIp.Name = "tbxSgIp";
            this.tbxSgIp.Size = new System.Drawing.Size(100, 20);
            this.tbxSgIp.TabIndex = 2;
            this.tbxSgIp.Text = "192.168.8.47";
            // 
            // tbxSaIp
            // 
            this.tbxSaIp.Location = new System.Drawing.Point(122, 30);
            this.tbxSaIp.Name = "tbxSaIp";
            this.tbxSaIp.Size = new System.Drawing.Size(100, 20);
            this.tbxSaIp.TabIndex = 3;
            this.tbxSaIp.Text = "192.168.8.24";
            // 
            // btnConnSg
            // 
            this.btnConnSg.Location = new System.Drawing.Point(16, 56);
            this.btnConnSg.Name = "btnConnSg";
            this.btnConnSg.Size = new System.Drawing.Size(75, 23);
            this.btnConnSg.TabIndex = 4;
            this.btnConnSg.Text = "Connect";
            this.btnConnSg.UseVisualStyleBackColor = true;
            this.btnConnSg.Click += new System.EventHandler(this.btnConnSg_Click);
            // 
            // btnConnSa
            // 
            this.btnConnSa.Location = new System.Drawing.Point(147, 56);
            this.btnConnSa.Name = "btnConnSa";
            this.btnConnSa.Size = new System.Drawing.Size(75, 23);
            this.btnConnSa.TabIndex = 5;
            this.btnConnSa.Text = "Connect";
            this.btnConnSa.UseVisualStyleBackColor = true;
            this.btnConnSa.Click += new System.EventHandler(this.btnConnSa_Click);
            // 
            // lblStartPower
            // 
            this.lblStartPower.AutoSize = true;
            this.lblStartPower.Location = new System.Drawing.Point(13, 183);
            this.lblStartPower.Name = "lblStartPower";
            this.lblStartPower.Size = new System.Drawing.Size(94, 13);
            this.lblStartPower.TabIndex = 6;
            this.lblStartPower.Text = "StartPower(dBuV):";
            this.lblStartPower.Visible = false;
            // 
            // tbxStartPower
            // 
            this.tbxStartPower.Location = new System.Drawing.Point(122, 180);
            this.tbxStartPower.Name = "tbxStartPower";
            this.tbxStartPower.Size = new System.Drawing.Size(100, 20);
            this.tbxStartPower.TabIndex = 7;
            this.tbxStartPower.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(295, 217);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbxCalDiagram
            // 
            this.pbxCalDiagram.Location = new System.Drawing.Point(16, 85);
            this.pbxCalDiagram.Name = "pbxCalDiagram";
            this.pbxCalDiagram.Size = new System.Drawing.Size(358, 89);
            this.pbxCalDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCalDiagram.TabIndex = 9;
            this.pbxCalDiagram.TabStop = false;
            // 
            // btnStartCal
            // 
            this.btnStartCal.Enabled = false;
            this.btnStartCal.Location = new System.Drawing.Point(295, 178);
            this.btnStartCal.Name = "btnStartCal";
            this.btnStartCal.Size = new System.Drawing.Size(75, 23);
            this.btnStartCal.TabIndex = 10;
            this.btnStartCal.Text = "StartCal";
            this.btnStartCal.UseVisualStyleBackColor = true;
            this.btnStartCal.Click += new System.EventHandler(this.btnStartCal_Click);
            // 
            // btnSkipCal
            // 
            this.btnSkipCal.Enabled = false;
            this.btnSkipCal.Location = new System.Drawing.Point(214, 178);
            this.btnSkipCal.Name = "btnSkipCal";
            this.btnSkipCal.Size = new System.Drawing.Size(75, 23);
            this.btnSkipCal.TabIndex = 11;
            this.btnSkipCal.Text = "SkipCal";
            this.btnSkipCal.UseVisualStyleBackColor = true;
            this.btnSkipCal.Click += new System.EventHandler(this.btnSkipCal_Click);
            // 
            // lblStopPower
            // 
            this.lblStopPower.AutoSize = true;
            this.lblStopPower.Location = new System.Drawing.Point(13, 222);
            this.lblStopPower.Name = "lblStopPower";
            this.lblStopPower.Size = new System.Drawing.Size(94, 13);
            this.lblStopPower.TabIndex = 12;
            this.lblStopPower.Text = "StopPower(dBuV):";
            this.lblStopPower.Visible = false;
            // 
            // tbxStopPower
            // 
            this.tbxStopPower.Location = new System.Drawing.Point(122, 219);
            this.tbxStopPower.Name = "tbxStopPower";
            this.tbxStopPower.Size = new System.Drawing.Size(100, 20);
            this.tbxStopPower.TabIndex = 8;
            this.tbxStopPower.Visible = false;
            // 
            // ckbxOneTimeMode
            // 
            this.ckbxOneTimeMode.AutoSize = true;
            this.ckbxOneTimeMode.Checked = true;
            this.ckbxOneTimeMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxOneTimeMode.Location = new System.Drawing.Point(274, 32);
            this.ckbxOneTimeMode.Name = "ckbxOneTimeMode";
            this.ckbxOneTimeMode.Size = new System.Drawing.Size(96, 17);
            this.ckbxOneTimeMode.TabIndex = 14;
            this.ckbxOneTimeMode.Text = "OneTimeMode";
            this.ckbxOneTimeMode.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(299, 56);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxCalFrequency
            // 
            this.tbxCalFrequency.Location = new System.Drawing.Point(122, 180);
            this.tbxCalFrequency.Name = "tbxCalFrequency";
            this.tbxCalFrequency.Size = new System.Drawing.Size(86, 20);
            this.tbxCalFrequency.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Frequency to Cal (Hz)";
            // 
            // fmP_1dB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxCalDiagram);
            this.Controls.Add(this.tbxCalFrequency);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.ckbxOneTimeMode);
            this.Controls.Add(this.tbxStopPower);
            this.Controls.Add(this.lblStopPower);
            this.Controls.Add(this.btnSkipCal);
            this.Controls.Add(this.btnStartCal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxStartPower);
            this.Controls.Add(this.lblStartPower);
            this.Controls.Add(this.btnConnSa);
            this.Controls.Add(this.btnConnSg);
            this.Controls.Add(this.tbxSaIp);
            this.Controls.Add(this.tbxSgIp);
            this.Controls.Add(this.lblRsSa);
            this.Controls.Add(this.lblRsSg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmP_1dB";
            this.Text = "1dB Compression Point";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRsSg;
        private System.Windows.Forms.Label lblRsSa;
        private System.Windows.Forms.TextBox tbxSgIp;
        private System.Windows.Forms.TextBox tbxSaIp;
        private System.Windows.Forms.Button btnConnSg;
        private System.Windows.Forms.Button btnConnSa;
        private System.Windows.Forms.Label lblStartPower;
        private System.Windows.Forms.TextBox tbxStartPower;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbxCalDiagram;
        private System.Windows.Forms.Button btnStartCal;
        private System.Windows.Forms.Button btnSkipCal;
        private System.Windows.Forms.Label lblStopPower;
        private System.Windows.Forms.TextBox tbxStopPower;
        private System.Windows.Forms.CheckBox ckbxOneTimeMode;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbxCalFrequency;
        private System.Windows.Forms.Label label1;
    }
}