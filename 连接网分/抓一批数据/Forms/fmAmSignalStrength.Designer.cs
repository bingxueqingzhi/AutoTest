namespace 抓一批数据.Forms
{
    partial class fmAmSignalStrength
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
            this.tbxSaIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPointsCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTotalTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSaIp
            // 
            this.tbxSaIp.Location = new System.Drawing.Point(76, 12);
            this.tbxSaIp.Name = "tbxSaIp";
            this.tbxSaIp.Size = new System.Drawing.Size(100, 20);
            this.tbxSaIp.TabIndex = 0;
            this.tbxSaIp.Text = "192.168.8.4";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(182, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(11, 117);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(473, 337);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 457);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Disconnected";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(182, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbxFreq
            // 
            this.tbxFreq.Location = new System.Drawing.Point(11, 91);
            this.tbxFreq.Name = "tbxFreq";
            this.tbxFreq.Size = new System.Drawing.Size(472, 20);
            this.tbxFreq.TabIndex = 5;
            this.tbxFreq.Text = "540,648,747,810,990,1080,1116,1233,1314,1521";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Point Count:";
            // 
            // tbxPointsCount
            // 
            this.tbxPointsCount.Location = new System.Drawing.Point(76, 38);
            this.tbxPointsCount.Name = "tbxPointsCount";
            this.tbxPointsCount.Size = new System.Drawing.Size(100, 20);
            this.tbxPointsCount.TabIndex = 8;
            this.tbxPointsCount.Text = "72";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Time:";
            // 
            // tbxTotalTime
            // 
            this.tbxTotalTime.Location = new System.Drawing.Point(76, 64);
            this.tbxTotalTime.Name = "tbxTotalTime";
            this.tbxTotalTime.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalTime.TabIndex = 10;
            this.tbxTotalTime.Text = "300";
            // 
            // fmAmSignalStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 479);
            this.Controls.Add(this.tbxTotalTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPointsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFreq);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxSaIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmAmSignalStrength";
            this.Text = "AmSignalStrength";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSaIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPointsCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTotalTime;
    }
}