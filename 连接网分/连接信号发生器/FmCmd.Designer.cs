namespace 连接信号发生器
{
    partial class FmCmd
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
            this.BtnSendCmd = new System.Windows.Forms.Button();
            this.TbxCmd = new System.Windows.Forms.TextBox();
            this.TbxReturn = new System.Windows.Forms.TextBox();
            this.chkbxSaveCsv = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSendCmd
            // 
            this.BtnSendCmd.Location = new System.Drawing.Point(197, 246);
            this.BtnSendCmd.Name = "BtnSendCmd";
            this.BtnSendCmd.Size = new System.Drawing.Size(75, 25);
            this.BtnSendCmd.TabIndex = 0;
            this.BtnSendCmd.Text = "SendCmd";
            this.BtnSendCmd.UseVisualStyleBackColor = true;
            this.BtnSendCmd.Click += new System.EventHandler(this.BtnSendCmd_Click);
            // 
            // TbxCmd
            // 
            this.TbxCmd.Location = new System.Drawing.Point(13, 14);
            this.TbxCmd.Name = "TbxCmd";
            this.TbxCmd.Size = new System.Drawing.Size(259, 20);
            this.TbxCmd.TabIndex = 1;
            // 
            // TbxReturn
            // 
            this.TbxReturn.Location = new System.Drawing.Point(13, 43);
            this.TbxReturn.Multiline = true;
            this.TbxReturn.Name = "TbxReturn";
            this.TbxReturn.Size = new System.Drawing.Size(259, 196);
            this.TbxReturn.TabIndex = 2;
            // 
            // chkbxSaveCsv
            // 
            this.chkbxSaveCsv.AutoSize = true;
            this.chkbxSaveCsv.Location = new System.Drawing.Point(13, 255);
            this.chkbxSaveCsv.Name = "chkbxSaveCsv";
            this.chkbxSaveCsv.Size = new System.Drawing.Size(69, 17);
            this.chkbxSaveCsv.TabIndex = 3;
            this.chkbxSaveCsv.Text = "SaveCsv";
            this.chkbxSaveCsv.UseVisualStyleBackColor = true;
            // 
            // FmCmd
            // 
            this.AcceptButton = this.BtnSendCmd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.chkbxSaveCsv);
            this.Controls.Add(this.TbxReturn);
            this.Controls.Add(this.TbxCmd);
            this.Controls.Add(this.BtnSendCmd);
            this.Name = "FmCmd";
            this.Text = "FmCmd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendCmd;
        private System.Windows.Forms.TextBox TbxCmd;
        private System.Windows.Forms.TextBox TbxReturn;
        private System.Windows.Forms.CheckBox chkbxSaveCsv;
    }
}