namespace 抓一批数据
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.tbxStop = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.btnStartKHz = new System.Windows.Forms.Button();
            this.btnStartMHz = new System.Windows.Forms.Button();
            this.btnStopMHz = new System.Windows.Forms.Button();
            this.btnStopKHz = new System.Windows.Forms.Button();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.tbxPoints = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAddMemory = new System.Windows.Forms.Button();
            this.lbxSetup = new System.Windows.Forms.ListBox();
            this.btnDelMemory = new System.Windows.Forms.Button();
            this.btnEditMemory = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSettingsConfirm = new System.Windows.Forms.Button();
            this.btnScanSettings = new System.Windows.Forms.Button();
            this.btnLoadNwa = new System.Windows.Forms.Button();
            this.ckbxReadFullData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxStart
            // 
            this.tbxStart.Enabled = false;
            this.tbxStart.Location = new System.Drawing.Point(12, 60);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(100, 20);
            this.tbxStart.TabIndex = 0;
            this.tbxStart.Text = "48";
            this.tbxStart.Visible = false;
            // 
            // tbxStop
            // 
            this.tbxStop.Enabled = false;
            this.tbxStop.Location = new System.Drawing.Point(118, 60);
            this.tbxStop.Name = "tbxStop";
            this.tbxStop.Size = new System.Drawing.Size(100, 20);
            this.tbxStop.TabIndex = 1;
            this.tbxStop.Text = "148";
            this.tbxStop.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(9, 44);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            this.lblStart.Visible = false;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(118, 43);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(29, 13);
            this.lblStop.TabIndex = 3;
            this.lblStop.Text = "Stop";
            this.lblStop.Visible = false;
            // 
            // btnStartKHz
            // 
            this.btnStartKHz.Enabled = false;
            this.btnStartKHz.Location = new System.Drawing.Point(12, 86);
            this.btnStartKHz.Name = "btnStartKHz";
            this.btnStartKHz.Size = new System.Drawing.Size(50, 23);
            this.btnStartKHz.TabIndex = 5;
            this.btnStartKHz.Text = "KHz";
            this.btnStartKHz.UseVisualStyleBackColor = true;
            this.btnStartKHz.Visible = false;
            this.btnStartKHz.Click += new System.EventHandler(this.btnStartKHz_Click);
            // 
            // btnStartMHz
            // 
            this.btnStartMHz.Enabled = false;
            this.btnStartMHz.Location = new System.Drawing.Point(62, 86);
            this.btnStartMHz.Name = "btnStartMHz";
            this.btnStartMHz.Size = new System.Drawing.Size(50, 23);
            this.btnStartMHz.TabIndex = 6;
            this.btnStartMHz.Text = "MHz";
            this.btnStartMHz.UseVisualStyleBackColor = true;
            this.btnStartMHz.Visible = false;
            this.btnStartMHz.Click += new System.EventHandler(this.btnStartMHz_Click);
            // 
            // btnStopMHz
            // 
            this.btnStopMHz.Enabled = false;
            this.btnStopMHz.Location = new System.Drawing.Point(168, 86);
            this.btnStopMHz.Name = "btnStopMHz";
            this.btnStopMHz.Size = new System.Drawing.Size(50, 23);
            this.btnStopMHz.TabIndex = 8;
            this.btnStopMHz.Text = "MHz";
            this.btnStopMHz.UseVisualStyleBackColor = true;
            this.btnStopMHz.Visible = false;
            this.btnStopMHz.Click += new System.EventHandler(this.btnStopMHz_Click);
            // 
            // btnStopKHz
            // 
            this.btnStopKHz.Enabled = false;
            this.btnStopKHz.Location = new System.Drawing.Point(118, 86);
            this.btnStopKHz.Name = "btnStopKHz";
            this.btnStopKHz.Size = new System.Drawing.Size(50, 23);
            this.btnStopKHz.TabIndex = 7;
            this.btnStopKHz.Text = "KHz";
            this.btnStopKHz.UseVisualStyleBackColor = true;
            this.btnStopKHz.Visible = false;
            this.btnStopKHz.Click += new System.EventHandler(this.btnStopKHz_Click);
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Enabled = false;
            this.btnSetFreq.Location = new System.Drawing.Point(224, 86);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(100, 23);
            this.btnSetFreq.TabIndex = 9;
            this.btnSetFreq.Text = "SetFreq";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Visible = false;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // tbxPoints
            // 
            this.tbxPoints.Enabled = false;
            this.tbxPoints.Location = new System.Drawing.Point(224, 60);
            this.tbxPoints.Name = "tbxPoints";
            this.tbxPoints.Size = new System.Drawing.Size(100, 20);
            this.tbxPoints.TabIndex = 10;
            this.tbxPoints.Text = "101";
            this.tbxPoints.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(224, 43);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 11;
            this.lblPoints.Text = "Points";
            this.lblPoints.Visible = false;
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(12, 13);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 12;
            this.tbxIP.Text = "192.168.0.5";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAddMemory
            // 
            this.btnAddMemory.Enabled = false;
            this.btnAddMemory.Location = new System.Drawing.Point(224, 115);
            this.btnAddMemory.Name = "btnAddMemory";
            this.btnAddMemory.Size = new System.Drawing.Size(75, 23);
            this.btnAddMemory.TabIndex = 17;
            this.btnAddMemory.Text = "Add...";
            this.btnAddMemory.UseVisualStyleBackColor = true;
            this.btnAddMemory.Click += new System.EventHandler(this.btnAddMemory_Click);
            // 
            // lbxSetup
            // 
            this.lbxSetup.FormattingEnabled = true;
            this.lbxSetup.Location = new System.Drawing.Point(12, 115);
            this.lbxSetup.Name = "lbxSetup";
            this.lbxSetup.Size = new System.Drawing.Size(206, 147);
            this.lbxSetup.TabIndex = 18;
            // 
            // btnDelMemory
            // 
            this.btnDelMemory.Enabled = false;
            this.btnDelMemory.Location = new System.Drawing.Point(224, 173);
            this.btnDelMemory.Name = "btnDelMemory";
            this.btnDelMemory.Size = new System.Drawing.Size(75, 23);
            this.btnDelMemory.TabIndex = 19;
            this.btnDelMemory.Text = "Remove";
            this.btnDelMemory.UseVisualStyleBackColor = true;
            // 
            // btnEditMemory
            // 
            this.btnEditMemory.Enabled = false;
            this.btnEditMemory.Location = new System.Drawing.Point(224, 144);
            this.btnEditMemory.Name = "btnEditMemory";
            this.btnEditMemory.Size = new System.Drawing.Size(75, 23);
            this.btnEditMemory.TabIndex = 20;
            this.btnEditMemory.Text = "Edit...";
            this.btnEditMemory.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(224, 239);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 21;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnSettingsConfirm
            // 
            this.btnSettingsConfirm.Enabled = false;
            this.btnSettingsConfirm.Location = new System.Drawing.Point(224, 202);
            this.btnSettingsConfirm.Name = "btnSettingsConfirm";
            this.btnSettingsConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsConfirm.TabIndex = 22;
            this.btnSettingsConfirm.Text = "Confirm";
            this.btnSettingsConfirm.UseVisualStyleBackColor = true;
            this.btnSettingsConfirm.Click += new System.EventHandler(this.btnSettingsConfirm_Click);
            // 
            // btnScanSettings
            // 
            this.btnScanSettings.Enabled = false;
            this.btnScanSettings.Location = new System.Drawing.Point(280, 12);
            this.btnScanSettings.Name = "btnScanSettings";
            this.btnScanSettings.Size = new System.Drawing.Size(75, 23);
            this.btnScanSettings.TabIndex = 23;
            this.btnScanSettings.Text = "UseCurrent";
            this.btnScanSettings.UseVisualStyleBackColor = true;
            this.btnScanSettings.Click += new System.EventHandler(this.btnScanSettings_Click);
            // 
            // btnLoadNwa
            // 
            this.btnLoadNwa.Location = new System.Drawing.Point(199, 12);
            this.btnLoadNwa.Name = "btnLoadNwa";
            this.btnLoadNwa.Size = new System.Drawing.Size(75, 23);
            this.btnLoadNwa.TabIndex = 24;
            this.btnLoadNwa.Text = "LoadNwa";
            this.btnLoadNwa.UseVisualStyleBackColor = true;
            this.btnLoadNwa.Click += new System.EventHandler(this.btnLoadNwa_Click);
            // 
            // ckbxReadFullData
            // 
            this.ckbxReadFullData.AutoSize = true;
            this.ckbxReadFullData.Location = new System.Drawing.Point(45, 43);
            this.ckbxReadFullData.Name = "ckbxReadFullData";
            this.ckbxReadFullData.Size = new System.Drawing.Size(119, 17);
            this.ckbxReadFullData.TabIndex = 25;
            this.ckbxReadFullData.Text = "ReadFullTraceData";
            this.ckbxReadFullData.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 266);
            this.Controls.Add(this.ckbxReadFullData);
            this.Controls.Add(this.btnLoadNwa);
            this.Controls.Add(this.btnScanSettings);
            this.Controls.Add(this.btnSettingsConfirm);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnEditMemory);
            this.Controls.Add(this.btnDelMemory);
            this.Controls.Add(this.lbxSetup);
            this.Controls.Add(this.btnAddMemory);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.tbxPoints);
            this.Controls.Add(this.btnSetFreq);
            this.Controls.Add(this.btnStopMHz);
            this.Controls.Add(this.btnStopKHz);
            this.Controls.Add(this.btnStartMHz);
            this.Controls.Add(this.btnStartKHz);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.tbxStop);
            this.Controls.Add(this.tbxStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "TestGetData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.TextBox tbxStop;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnStartKHz;
        private System.Windows.Forms.Button btnStartMHz;
        private System.Windows.Forms.Button btnStopMHz;
        private System.Windows.Forms.Button btnStopKHz;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.TextBox tbxPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAddMemory;
        private System.Windows.Forms.ListBox lbxSetup;
        private System.Windows.Forms.Button btnDelMemory;
        private System.Windows.Forms.Button btnEditMemory;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnSettingsConfirm;
        private System.Windows.Forms.Button btnScanSettings;
        private System.Windows.Forms.Button btnLoadNwa;
        private System.Windows.Forms.CheckBox ckbxReadFullData;
    }
}

