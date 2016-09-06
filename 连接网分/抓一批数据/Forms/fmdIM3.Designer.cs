namespace 抓一批数据.Forms
{
    partial class fmdIM3
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
            this.tbxSg1Ip = new System.Windows.Forms.TextBox();
            this.tbxSg2Ip = new System.Windows.Forms.TextBox();
            this.tbxSaIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSg1Conn = new System.Windows.Forms.Button();
            this.btnSg2Conn = new System.Windows.Forms.Button();
            this.btnSaConn = new System.Windows.Forms.Button();
            this.ckbxOneTimeMode = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.pbxDiagram = new System.Windows.Forms.PictureBox();
            this.btnStartCal = new System.Windows.Forms.Button();
            this.btnSkipCal = new System.Windows.Forms.Button();
            this.tbxFreq1 = new System.Windows.Forms.TextBox();
            this.tbxFreq2 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiagram)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSg1Ip
            // 
            this.tbxSg1Ip.Location = new System.Drawing.Point(12, 29);
            this.tbxSg1Ip.Name = "tbxSg1Ip";
            this.tbxSg1Ip.Size = new System.Drawing.Size(100, 20);
            this.tbxSg1Ip.TabIndex = 0;
            this.tbxSg1Ip.Text = "192.168.8.2";
            // 
            // tbxSg2Ip
            // 
            this.tbxSg2Ip.Location = new System.Drawing.Point(118, 29);
            this.tbxSg2Ip.Name = "tbxSg2Ip";
            this.tbxSg2Ip.Size = new System.Drawing.Size(100, 20);
            this.tbxSg2Ip.TabIndex = 1;
            this.tbxSg2Ip.Text = "192.168.8.3";
            // 
            // tbxSaIp
            // 
            this.tbxSaIp.Location = new System.Drawing.Point(224, 29);
            this.tbxSaIp.Name = "tbxSaIp";
            this.tbxSaIp.Size = new System.Drawing.Size(100, 20);
            this.tbxSaIp.TabIndex = 2;
            this.tbxSaIp.Text = "192.168.8.4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SG1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SG2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SA";
            // 
            // btnSg1Conn
            // 
            this.btnSg1Conn.Location = new System.Drawing.Point(12, 56);
            this.btnSg1Conn.Name = "btnSg1Conn";
            this.btnSg1Conn.Size = new System.Drawing.Size(75, 23);
            this.btnSg1Conn.TabIndex = 6;
            this.btnSg1Conn.Text = "Connect";
            this.btnSg1Conn.UseVisualStyleBackColor = true;
            this.btnSg1Conn.Click += new System.EventHandler(this.btnSg1Conn_Click);
            // 
            // btnSg2Conn
            // 
            this.btnSg2Conn.Location = new System.Drawing.Point(118, 56);
            this.btnSg2Conn.Name = "btnSg2Conn";
            this.btnSg2Conn.Size = new System.Drawing.Size(75, 23);
            this.btnSg2Conn.TabIndex = 7;
            this.btnSg2Conn.Text = "Connect";
            this.btnSg2Conn.UseVisualStyleBackColor = true;
            this.btnSg2Conn.Click += new System.EventHandler(this.btnSg2Conn_Click);
            // 
            // btnSaConn
            // 
            this.btnSaConn.Location = new System.Drawing.Point(224, 56);
            this.btnSaConn.Name = "btnSaConn";
            this.btnSaConn.Size = new System.Drawing.Size(75, 23);
            this.btnSaConn.TabIndex = 8;
            this.btnSaConn.Text = "Connect";
            this.btnSaConn.UseVisualStyleBackColor = true;
            this.btnSaConn.Click += new System.EventHandler(this.btnSaConn_Click);
            // 
            // ckbxOneTimeMode
            // 
            this.ckbxOneTimeMode.AutoSize = true;
            this.ckbxOneTimeMode.Checked = true;
            this.ckbxOneTimeMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxOneTimeMode.Location = new System.Drawing.Point(330, 31);
            this.ckbxOneTimeMode.Name = "ckbxOneTimeMode";
            this.ckbxOneTimeMode.Size = new System.Drawing.Size(96, 17);
            this.ckbxOneTimeMode.TabIndex = 9;
            this.ckbxOneTimeMode.Text = "OneTimeMode";
            this.ckbxOneTimeMode.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(330, 56);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pbxDiagram
            // 
            this.pbxDiagram.Location = new System.Drawing.Point(12, 86);
            this.pbxDiagram.Name = "pbxDiagram";
            this.pbxDiagram.Size = new System.Drawing.Size(407, 158);
            this.pbxDiagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDiagram.TabIndex = 11;
            this.pbxDiagram.TabStop = false;
            // 
            // btnStartCal
            // 
            this.btnStartCal.Location = new System.Drawing.Point(330, 249);
            this.btnStartCal.Name = "btnStartCal";
            this.btnStartCal.Size = new System.Drawing.Size(75, 23);
            this.btnStartCal.TabIndex = 12;
            this.btnStartCal.Text = "StartCal";
            this.btnStartCal.UseVisualStyleBackColor = true;
            this.btnStartCal.Click += new System.EventHandler(this.btnStartCal_Click);
            // 
            // btnSkipCal
            // 
            this.btnSkipCal.Location = new System.Drawing.Point(249, 249);
            this.btnSkipCal.Name = "btnSkipCal";
            this.btnSkipCal.Size = new System.Drawing.Size(75, 23);
            this.btnSkipCal.TabIndex = 13;
            this.btnSkipCal.Text = "SkipCal";
            this.btnSkipCal.UseVisualStyleBackColor = true;
            // 
            // tbxFreq1
            // 
            this.tbxFreq1.Location = new System.Drawing.Point(12, 251);
            this.tbxFreq1.Name = "tbxFreq1";
            this.tbxFreq1.Size = new System.Drawing.Size(100, 20);
            this.tbxFreq1.TabIndex = 14;
            this.tbxFreq1.Text = "92000000";
            // 
            // tbxFreq2
            // 
            this.tbxFreq2.Location = new System.Drawing.Point(118, 251);
            this.tbxFreq2.Name = "tbxFreq2";
            this.tbxFreq2.Size = new System.Drawing.Size(100, 20);
            this.tbxFreq2.TabIndex = 15;
            this.tbxFreq2.Text = "93000000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(330, 278);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fmdIM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 402);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxFreq2);
            this.Controls.Add(this.tbxFreq1);
            this.Controls.Add(this.btnSkipCal);
            this.Controls.Add(this.btnStartCal);
            this.Controls.Add(this.pbxDiagram);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.ckbxOneTimeMode);
            this.Controls.Add(this.btnSaConn);
            this.Controls.Add(this.btnSg2Conn);
            this.Controls.Add(this.btnSg1Conn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSaIp);
            this.Controls.Add(this.tbxSg2Ip);
            this.Controls.Add(this.tbxSg1Ip);
            this.Name = "fmdIM3";
            this.Text = "dIM3";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSg1Ip;
        private System.Windows.Forms.TextBox tbxSg2Ip;
        private System.Windows.Forms.TextBox tbxSaIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSg1Conn;
        private System.Windows.Forms.Button btnSg2Conn;
        private System.Windows.Forms.Button btnSaConn;
        private System.Windows.Forms.CheckBox ckbxOneTimeMode;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.PictureBox pbxDiagram;
        private System.Windows.Forms.Button btnStartCal;
        private System.Windows.Forms.Button btnSkipCal;
        private System.Windows.Forms.TextBox tbxFreq1;
        private System.Windows.Forms.TextBox tbxFreq2;
        private System.Windows.Forms.Button btnStart;
    }
}