namespace 抓一批数据.Forms
{
    partial class fmSetRsSgOffset
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
            this.tbxOffSet = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMinu = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.tbxPowerOffset = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPowerMinu = new System.Windows.Forms.Button();
            this.btnPowerPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxOffSet
            // 
            this.tbxOffSet.Location = new System.Drawing.Point(13, 13);
            this.tbxOffSet.Name = "tbxOffSet";
            this.tbxOffSet.Size = new System.Drawing.Size(100, 20);
            this.tbxOffSet.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(119, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMinu
            // 
            this.btnMinu.Location = new System.Drawing.Point(13, 40);
            this.btnMinu.Name = "btnMinu";
            this.btnMinu.Size = new System.Drawing.Size(50, 23);
            this.btnMinu.TabIndex = 2;
            this.btnMinu.Text = "-";
            this.btnMinu.UseVisualStyleBackColor = true;
            this.btnMinu.Click += new System.EventHandler(this.btnMinu_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(63, 40);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // cbxUnit
            // 
            this.cbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "Hz",
            "kHz",
            "MHz"});
            this.cbxUnit.Location = new System.Drawing.Point(119, 13);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(76, 21);
            this.cbxUnit.TabIndex = 4;
            // 
            // tbxPowerOffset
            // 
            this.tbxPowerOffset.Location = new System.Drawing.Point(13, 70);
            this.tbxPowerOffset.Name = "tbxPowerOffset";
            this.tbxPowerOffset.Size = new System.Drawing.Size(100, 20);
            this.tbxPowerOffset.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dBuV",
            "uV",
            "mV",
            "dBm"});
            this.comboBox1.Location = new System.Drawing.Point(119, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnPowerMinu
            // 
            this.btnPowerMinu.Location = new System.Drawing.Point(13, 96);
            this.btnPowerMinu.Name = "btnPowerMinu";
            this.btnPowerMinu.Size = new System.Drawing.Size(50, 23);
            this.btnPowerMinu.TabIndex = 7;
            this.btnPowerMinu.Text = "-";
            this.btnPowerMinu.UseVisualStyleBackColor = true;
            // 
            // btnPowerPlus
            // 
            this.btnPowerPlus.Location = new System.Drawing.Point(63, 96);
            this.btnPowerPlus.Name = "btnPowerPlus";
            this.btnPowerPlus.Size = new System.Drawing.Size(50, 23);
            this.btnPowerPlus.TabIndex = 8;
            this.btnPowerPlus.Text = "+";
            this.btnPowerPlus.UseVisualStyleBackColor = true;
            // 
            // fmSetRsSgOffset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 153);
            this.Controls.Add(this.btnPowerPlus);
            this.Controls.Add(this.btnPowerMinu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxPowerOffset);
            this.Controls.Add(this.cbxUnit);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinu);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxOffSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSetRsSgOffset";
            this.Text = "Set Offset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOffSet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMinu;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.TextBox tbxPowerOffset;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPowerMinu;
        private System.Windows.Forms.Button btnPowerPlus;
    }
}