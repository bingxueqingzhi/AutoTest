namespace 连接信号发生器
{
    partial class FmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TbxIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnScreenShot = new System.Windows.Forms.Button();
            this.TbxLog = new System.Windows.Forms.TextBox();
            this.BtnCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxIP
            // 
            this.TbxIP.Location = new System.Drawing.Point(13, 14);
            this.TbxIP.Name = "TbxIP";
            this.TbxIP.Size = new System.Drawing.Size(100, 20);
            this.TbxIP.TabIndex = 0;
            this.TbxIP.Text = "192.168.0.9";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(119, 14);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 25);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnScreenShot
            // 
            this.BtnScreenShot.Enabled = false;
            this.BtnScreenShot.Location = new System.Drawing.Point(200, 14);
            this.BtnScreenShot.Name = "BtnScreenShot";
            this.BtnScreenShot.Size = new System.Drawing.Size(75, 25);
            this.BtnScreenShot.TabIndex = 2;
            this.BtnScreenShot.Text = "ScreenShot";
            this.BtnScreenShot.UseVisualStyleBackColor = true;
            this.BtnScreenShot.Click += new System.EventHandler(this.BtnScreenShot_Click);
            // 
            // TbxLog
            // 
            this.TbxLog.Location = new System.Drawing.Point(13, 43);
            this.TbxLog.Multiline = true;
            this.TbxLog.Name = "TbxLog";
            this.TbxLog.ReadOnly = true;
            this.TbxLog.Size = new System.Drawing.Size(259, 227);
            this.TbxLog.TabIndex = 3;
            // 
            // BtnCmd
            // 
            this.BtnCmd.Enabled = false;
            this.BtnCmd.Location = new System.Drawing.Point(281, 14);
            this.BtnCmd.Name = "BtnCmd";
            this.BtnCmd.Size = new System.Drawing.Size(75, 25);
            this.BtnCmd.TabIndex = 4;
            this.BtnCmd.Text = "CMD";
            this.BtnCmd.UseVisualStyleBackColor = true;
            this.BtnCmd.Click += new System.EventHandler(this.BtnCmd_Click);
            // 
            // FmMain
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 284);
            this.Controls.Add(this.BtnCmd);
            this.Controls.Add(this.TbxLog);
            this.Controls.Add(this.BtnScreenShot);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TbxIP);
            this.Name = "FmMain";
            this.Text = "FmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIP;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnScreenShot;
        private System.Windows.Forms.TextBox TbxLog;
        private System.Windows.Forms.Button BtnCmd;
    }
}

