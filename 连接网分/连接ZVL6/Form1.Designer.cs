namespace 连接ZVL6
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
            this.BtnScreenShot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxIP
            // 
            this.TbxIP.Location = new System.Drawing.Point(26, 23);
            this.TbxIP.Name = "TbxIP";
            this.TbxIP.Size = new System.Drawing.Size(100, 20);
            this.TbxIP.TabIndex = 0;
            this.TbxIP.Text = "192.168.0.5";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(133, 19);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnScreenShot
            // 
            this.BtnScreenShot.Enabled = false;
            this.BtnScreenShot.Location = new System.Drawing.Point(133, 48);
            this.BtnScreenShot.Name = "BtnScreenShot";
            this.BtnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.BtnScreenShot.TabIndex = 2;
            this.BtnScreenShot.Text = "ScreenShot";
            this.BtnScreenShot.UseVisualStyleBackColor = true;
            this.BtnScreenShot.Click += new System.EventHandler(this.BtnScreenShot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnScreenShot);
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
        private System.Windows.Forms.Button BtnScreenShot;
    }
}

