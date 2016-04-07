namespace 导出marker数据
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
            this.TbxIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.BtnSaveCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxIP
            // 
            this.TbxIP.Location = new System.Drawing.Point(13, 13);
            this.TbxIP.Name = "TbxIP";
            this.TbxIP.Size = new System.Drawing.Size(178, 20);
            this.TbxIP.TabIndex = 0;
            this.TbxIP.Text = "192.168.0.5";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(197, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.Enabled = false;
            this.BtnDownload.Location = new System.Drawing.Point(197, 38);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(75, 23);
            this.BtnDownload.TabIndex = 2;
            this.BtnDownload.Text = "Download MKR";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // TbxLog
            // 
            this.TbxLog.Location = new System.Drawing.Point(13, 40);
            this.TbxLog.Multiline = true;
            this.TbxLog.Name = "TbxLog";
            this.TbxLog.ReadOnly = true;
            this.TbxLog.Size = new System.Drawing.Size(178, 210);
            this.TbxLog.TabIndex = 3;
            // 
            // BtnSaveCsv
            // 
            this.BtnSaveCsv.Enabled = false;
            this.BtnSaveCsv.Location = new System.Drawing.Point(197, 67);
            this.BtnSaveCsv.Name = "BtnSaveCsv";
            this.BtnSaveCsv.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveCsv.TabIndex = 4;
            this.BtnSaveCsv.Text = "Save";
            this.BtnSaveCsv.UseVisualStyleBackColor = true;
            this.BtnSaveCsv.Click += new System.EventHandler(this.BtnSaveCsv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnSaveCsv);
            this.Controls.Add(this.TbxLog);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TbxIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIP;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.TextBox TbxLog;
        private System.Windows.Forms.Button BtnSaveCsv;
    }
}

