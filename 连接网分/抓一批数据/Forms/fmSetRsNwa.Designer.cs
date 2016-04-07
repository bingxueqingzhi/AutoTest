namespace 抓一批数据
{
    partial class fmSetRsNwa
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
            this.tbxMemName = new System.Windows.Forms.TextBox();
            this.lblMemName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.tbxStop = new System.Windows.Forms.TextBox();
            this.btnAddTrace = new System.Windows.Forms.Button();
            this.btnEditTrace = new System.Windows.Forms.Button();
            this.btnDeleteTrace = new System.Windows.Forms.Button();
            this.lbxTraceInfo = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMemName
            // 
            this.tbxMemName.Location = new System.Drawing.Point(12, 29);
            this.tbxMemName.Name = "tbxMemName";
            this.tbxMemName.Size = new System.Drawing.Size(100, 20);
            this.tbxMemName.TabIndex = 0;
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Location = new System.Drawing.Point(12, 13);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(72, 13);
            this.lblMemName.TabIndex = 2;
            this.lblMemName.Text = "MemoryName";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(15, 56);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start";
            // 
            // tbxStart
            // 
            this.tbxStart.Location = new System.Drawing.Point(13, 73);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(100, 20);
            this.tbxStart.TabIndex = 6;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(127, 56);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(29, 13);
            this.lblStop.TabIndex = 7;
            this.lblStop.Text = "Stop";
            // 
            // tbxStop
            // 
            this.tbxStop.Location = new System.Drawing.Point(118, 73);
            this.tbxStop.Name = "tbxStop";
            this.tbxStop.Size = new System.Drawing.Size(100, 20);
            this.tbxStop.TabIndex = 8;
            // 
            // btnAddTrace
            // 
            this.btnAddTrace.Location = new System.Drawing.Point(12, 99);
            this.btnAddTrace.Name = "btnAddTrace";
            this.btnAddTrace.Size = new System.Drawing.Size(50, 23);
            this.btnAddTrace.TabIndex = 9;
            this.btnAddTrace.Text = "Add...";
            this.btnAddTrace.UseVisualStyleBackColor = true;
            this.btnAddTrace.Click += new System.EventHandler(this.btnAddTrace_Click);
            // 
            // btnEditTrace
            // 
            this.btnEditTrace.Location = new System.Drawing.Point(68, 99);
            this.btnEditTrace.Name = "btnEditTrace";
            this.btnEditTrace.Size = new System.Drawing.Size(50, 23);
            this.btnEditTrace.TabIndex = 10;
            this.btnEditTrace.Text = "Edit...";
            this.btnEditTrace.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrace
            // 
            this.btnDeleteTrace.Location = new System.Drawing.Point(168, 99);
            this.btnDeleteTrace.Name = "btnDeleteTrace";
            this.btnDeleteTrace.Size = new System.Drawing.Size(50, 23);
            this.btnDeleteTrace.TabIndex = 11;
            this.btnDeleteTrace.Text = "Delete";
            this.btnDeleteTrace.UseVisualStyleBackColor = true;
            // 
            // lbxTraceInfo
            // 
            this.lbxTraceInfo.FormattingEnabled = true;
            this.lbxTraceInfo.Location = new System.Drawing.Point(12, 128);
            this.lbxTraceInfo.Name = "lbxTraceInfo";
            this.lbxTraceInfo.Size = new System.Drawing.Size(206, 134);
            this.lbxTraceInfo.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(143, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fmSetRsNwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbxTraceInfo);
            this.Controls.Add(this.btnDeleteTrace);
            this.Controls.Add(this.btnEditTrace);
            this.Controls.Add(this.btnAddTrace);
            this.Controls.Add(this.tbxStop);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.tbxStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblMemName);
            this.Controls.Add(this.tbxMemName);
            this.Name = "fmSetRsNwa";
            this.Text = "Edit Nwa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMemName;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.TextBox tbxStop;
        private System.Windows.Forms.Button btnAddTrace;
        private System.Windows.Forms.Button btnEditTrace;
        private System.Windows.Forms.Button btnDeleteTrace;
        private System.Windows.Forms.ListBox lbxTraceInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}