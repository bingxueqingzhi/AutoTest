namespace 抓一批数据.Forms
{
    partial class fmSetRsSa
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
            this.tbxRBW = new System.Windows.Forms.TextBox();
            this.tbxVBW = new System.Windows.Forms.TextBox();
            this.btnRBW = new System.Windows.Forms.Button();
            this.btnVBW = new System.Windows.Forms.Button();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.cbxStartUnit = new System.Windows.Forms.ComboBox();
            this.tbxStop = new System.Windows.Forms.TextBox();
            this.cbxStopUnit = new System.Windows.Forms.ComboBox();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.tbxIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRBW
            // 
            this.tbxRBW.Location = new System.Drawing.Point(12, 39);
            this.tbxRBW.Name = "tbxRBW";
            this.tbxRBW.Size = new System.Drawing.Size(100, 20);
            this.tbxRBW.TabIndex = 0;
            // 
            // tbxVBW
            // 
            this.tbxVBW.Location = new System.Drawing.Point(12, 66);
            this.tbxVBW.Name = "tbxVBW";
            this.tbxVBW.Size = new System.Drawing.Size(100, 20);
            this.tbxVBW.TabIndex = 1;
            // 
            // btnRBW
            // 
            this.btnRBW.Location = new System.Drawing.Point(118, 37);
            this.btnRBW.Name = "btnRBW";
            this.btnRBW.Size = new System.Drawing.Size(75, 23);
            this.btnRBW.TabIndex = 2;
            this.btnRBW.Text = "RBW";
            this.btnRBW.UseVisualStyleBackColor = true;
            // 
            // btnVBW
            // 
            this.btnVBW.Location = new System.Drawing.Point(118, 64);
            this.btnVBW.Name = "btnVBW";
            this.btnVBW.Size = new System.Drawing.Size(75, 23);
            this.btnVBW.TabIndex = 3;
            this.btnVBW.Text = "VBW";
            this.btnVBW.UseVisualStyleBackColor = true;
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(12, 92);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(100, 20);
            this.tbxStart.TabIndex = 4;
            // 
            // cbxStartUnit
            // 
            this.cbxStartUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStartUnit.FormattingEnabled = true;
            this.cbxStartUnit.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz"});
            this.cbxStartUnit.Location = new System.Drawing.Point(118, 92);
            this.cbxStartUnit.Name = "cbxStartUnit";
            this.cbxStartUnit.Size = new System.Drawing.Size(75, 21);
            this.cbxStartUnit.TabIndex = 5;
            // 
            // tbxStop
            // 
            this.tbxStop.Location = new System.Drawing.Point(12, 119);
            this.tbxStop.Name = "tbxStop";
            this.tbxStop.Size = new System.Drawing.Size(100, 20);
            this.tbxStop.TabIndex = 6;
            // 
            // cbxStopUnit
            // 
            this.cbxStopUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStopUnit.FormattingEnabled = true;
            this.cbxStopUnit.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz"});
            this.cbxStopUnit.Location = new System.Drawing.Point(118, 119);
            this.cbxStopUnit.Name = "cbxStopUnit";
            this.cbxStopUnit.Size = new System.Drawing.Size(75, 21);
            this.cbxStopUnit.TabIndex = 7;
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(196, 39);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(75, 101);
            this.btnSetFreq.TabIndex = 8;
            this.btnSetFreq.Text = "SetFreq";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(13, 146);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(54, 13);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "TestLabel";
            // 
            // tbxIp
            // 
            this.tbxIp.Location = new System.Drawing.Point(12, 13);
            this.tbxIp.Name = "tbxIp";
            this.tbxIp.Size = new System.Drawing.Size(100, 20);
            this.tbxIp.TabIndex = 10;
            this.tbxIp.Text = "192.168.8.24";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // fmSetRsSa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIp);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnSetFreq);
            this.Controls.Add(this.cbxStopUnit);
            this.Controls.Add(this.tbxStop);
            this.Controls.Add(this.cbxStartUnit);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.btnVBW);
            this.Controls.Add(this.btnRBW);
            this.Controls.Add(this.tbxVBW);
            this.Controls.Add(this.tbxRBW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSetRsSa";
            this.Text = "SetRsSa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRBW;
        private System.Windows.Forms.TextBox tbxVBW;
        private System.Windows.Forms.Button btnRBW;
        private System.Windows.Forms.Button btnVBW;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.ComboBox cbxStartUnit;
        private System.Windows.Forms.TextBox tbxStop;
        private System.Windows.Forms.ComboBox cbxStopUnit;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox tbxIp;
        private System.Windows.Forms.Button btnConnect;
    }
}