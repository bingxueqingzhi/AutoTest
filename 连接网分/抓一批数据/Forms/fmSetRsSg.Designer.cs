namespace 抓一批数据.Forms
{
    partial class fmSetRsSg
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
            this.lblFreq = new System.Windows.Forms.Label();
            this.tbxFreq = new System.Windows.Forms.TextBox();
            this.cbxFreqUnit = new System.Windows.Forms.ComboBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.tbxPower = new System.Windows.Forms.TextBox();
            this.cbxPowerUnit = new System.Windows.Forms.ComboBox();
            this.btnSetFreqPower = new System.Windows.Forms.Button();
            this.btnModGen = new System.Windows.Forms.Button();
            this.btnModulation = new System.Windows.Forms.Button();
            this.btnRF = new System.Windows.Forms.Button();
            this.lblIP = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnOffset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(12, 48);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(57, 13);
            this.lblFreq.TabIndex = 0;
            this.lblFreq.Text = "Frequency";
            // 
            // tbxFreq
            // 
            this.tbxFreq.Location = new System.Drawing.Point(15, 65);
            this.tbxFreq.Name = "tbxFreq";
            this.tbxFreq.Size = new System.Drawing.Size(100, 20);
            this.tbxFreq.TabIndex = 1;
            this.tbxFreq.TextChanged += new System.EventHandler(this.tbxFreq_TextChanged);
            // 
            // cbxFreqUnit
            // 
            this.cbxFreqUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFreqUnit.FormattingEnabled = true;
            this.cbxFreqUnit.Items.AddRange(new object[] {
            "KHz",
            "MHz",
            "GHz"});
            this.cbxFreqUnit.Location = new System.Drawing.Point(112, 65);
            this.cbxFreqUnit.Name = "cbxFreqUnit";
            this.cbxFreqUnit.Size = new System.Drawing.Size(68, 21);
            this.cbxFreqUnit.TabIndex = 2;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(12, 88);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(37, 13);
            this.lblPower.TabIndex = 3;
            this.lblPower.Text = "Power";
            // 
            // tbxPower
            // 
            this.tbxPower.Location = new System.Drawing.Point(15, 105);
            this.tbxPower.Name = "tbxPower";
            this.tbxPower.Size = new System.Drawing.Size(100, 20);
            this.tbxPower.TabIndex = 4;
            this.tbxPower.TextChanged += new System.EventHandler(this.tbxPower_TextChanged);
            // 
            // cbxPowerUnit
            // 
            this.cbxPowerUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPowerUnit.FormattingEnabled = true;
            this.cbxPowerUnit.Items.AddRange(new object[] {
            "dBuV",
            "dBm",
            "nV",
            "uV",
            "mV",
            "V"});
            this.cbxPowerUnit.Location = new System.Drawing.Point(112, 105);
            this.cbxPowerUnit.Name = "cbxPowerUnit";
            this.cbxPowerUnit.Size = new System.Drawing.Size(68, 21);
            this.cbxPowerUnit.TabIndex = 5;
            // 
            // btnSetFreqPower
            // 
            this.btnSetFreqPower.Enabled = false;
            this.btnSetFreqPower.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetFreqPower.Location = new System.Drawing.Point(187, 65);
            this.btnSetFreqPower.Name = "btnSetFreqPower";
            this.btnSetFreqPower.Size = new System.Drawing.Size(75, 61);
            this.btnSetFreqPower.TabIndex = 6;
            this.btnSetFreqPower.Text = "SET!";
            this.btnSetFreqPower.UseVisualStyleBackColor = true;
            this.btnSetFreqPower.Click += new System.EventHandler(this.btnSetFreqPower_Click);
            // 
            // btnModGen
            // 
            this.btnModGen.Enabled = false;
            this.btnModGen.Location = new System.Drawing.Point(16, 134);
            this.btnModGen.Name = "btnModGen";
            this.btnModGen.Size = new System.Drawing.Size(75, 23);
            this.btnModGen.TabIndex = 7;
            this.btnModGen.Text = "Mod Gen";
            this.btnModGen.UseVisualStyleBackColor = true;
            // 
            // btnModulation
            // 
            this.btnModulation.Enabled = false;
            this.btnModulation.Location = new System.Drawing.Point(97, 134);
            this.btnModulation.Name = "btnModulation";
            this.btnModulation.Size = new System.Drawing.Size(75, 23);
            this.btnModulation.TabIndex = 8;
            this.btnModulation.Text = "Modulation";
            this.btnModulation.UseVisualStyleBackColor = true;
            // 
            // btnRF
            // 
            this.btnRF.Enabled = false;
            this.btnRF.Location = new System.Drawing.Point(178, 134);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(75, 23);
            this.btnRF.TabIndex = 9;
            this.btnRF.Text = "RF";
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnRF_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(54, 13);
            this.lblIP.TabIndex = 10;
            this.lblIP.Text = "IpAddress";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(16, 23);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(100, 20);
            this.tbxIP.TabIndex = 11;
            this.tbxIP.Text = "192.168.0.17";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(112, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnOffset
            // 
            this.btnOffset.Enabled = false;
            this.btnOffset.Location = new System.Drawing.Point(187, 23);
            this.btnOffset.Name = "btnOffset";
            this.btnOffset.Size = new System.Drawing.Size(75, 23);
            this.btnOffset.TabIndex = 13;
            this.btnOffset.Text = "Offset";
            this.btnOffset.UseVisualStyleBackColor = true;
            this.btnOffset.Click += new System.EventHandler(this.btnOffset_Click);
            // 
            // fmSetRsSg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.btnOffset);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnRF);
            this.Controls.Add(this.btnModulation);
            this.Controls.Add(this.btnModGen);
            this.Controls.Add(this.btnSetFreqPower);
            this.Controls.Add(this.cbxPowerUnit);
            this.Controls.Add(this.tbxPower);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.cbxFreqUnit);
            this.Controls.Add(this.tbxFreq);
            this.Controls.Add(this.lblFreq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fmSetRsSg";
            this.Text = "fmSetRsSg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.TextBox tbxFreq;
        private System.Windows.Forms.ComboBox cbxFreqUnit;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox tbxPower;
        private System.Windows.Forms.ComboBox cbxPowerUnit;
        private System.Windows.Forms.Button btnSetFreqPower;
        private System.Windows.Forms.Button btnModGen;
        private System.Windows.Forms.Button btnModulation;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnOffset;
    }
}