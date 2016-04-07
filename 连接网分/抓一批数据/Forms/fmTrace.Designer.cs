namespace 抓一批数据
{
    partial class fmTrace
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
            this.lblTraceName = new System.Windows.Forms.Label();
            this.tbxTraceName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTraceTitle = new System.Windows.Forms.TextBox();
            this.lblTraceMeasure = new System.Windows.Forms.Label();
            this.cbxMeasure = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTraceName
            // 
            this.lblTraceName.AutoSize = true;
            this.lblTraceName.Location = new System.Drawing.Point(13, 13);
            this.lblTraceName.Name = "lblTraceName";
            this.lblTraceName.Size = new System.Drawing.Size(35, 13);
            this.lblTraceName.TabIndex = 0;
            this.lblTraceName.Text = "Name";
            // 
            // tbxTraceName
            // 
            this.tbxTraceName.Location = new System.Drawing.Point(16, 30);
            this.tbxTraceName.Name = "tbxTraceName";
            this.tbxTraceName.Size = new System.Drawing.Size(100, 20);
            this.tbxTraceName.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(119, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // tbxTraceTitle
            // 
            this.tbxTraceTitle.Location = new System.Drawing.Point(122, 30);
            this.tbxTraceTitle.Name = "tbxTraceTitle";
            this.tbxTraceTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxTraceTitle.TabIndex = 3;
            // 
            // lblTraceMeasure
            // 
            this.lblTraceMeasure.AutoSize = true;
            this.lblTraceMeasure.Location = new System.Drawing.Point(13, 53);
            this.lblTraceMeasure.Name = "lblTraceMeasure";
            this.lblTraceMeasure.Size = new System.Drawing.Size(37, 13);
            this.lblTraceMeasure.TabIndex = 4;
            this.lblTraceMeasure.Text = "MEAS";
            // 
            // cbxMeasure
            // 
            this.cbxMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeasure.FormattingEnabled = true;
            this.cbxMeasure.Items.AddRange(new object[] {
            "S11",
            "S21",
            "S12",
            "S22"});
            this.cbxMeasure.Location = new System.Drawing.Point(13, 70);
            this.cbxMeasure.Name = "cbxMeasure";
            this.cbxMeasure.Size = new System.Drawing.Size(100, 21);
            this.cbxMeasure.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxFormat
            // 
            this.cbxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormat.FormattingEnabled = true;
            this.cbxFormat.Items.AddRange(new object[] {
            "MLINear",
            "MLOGarithmic",
            "PHASe",
            "UPHase",
            "POLar",
            "SMITh",
            "ISMith",
            "GDELay",
            "REAL",
            "IMAGinary",
            "SWR",
            "COMPlex",
            "MAGNitude"});
            this.cbxFormat.Location = new System.Drawing.Point(122, 70);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(100, 21);
            this.cbxFormat.TabIndex = 9;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(119, 54);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(39, 13);
            this.lblFormat.TabIndex = 8;
            this.lblFormat.Text = "Format";
            // 
            // fmTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 165);
            this.Controls.Add(this.cbxFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxMeasure);
            this.Controls.Add(this.lblTraceMeasure);
            this.Controls.Add(this.tbxTraceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxTraceName);
            this.Controls.Add(this.lblTraceName);
            this.Name = "fmTrace";
            this.Text = "Edit Trace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraceName;
        private System.Windows.Forms.TextBox tbxTraceName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTraceTitle;
        private System.Windows.Forms.Label lblTraceMeasure;
        private System.Windows.Forms.ComboBox cbxMeasure;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.Label lblFormat;
    }
}