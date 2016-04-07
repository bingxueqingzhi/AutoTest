namespace 抓一批数据
{
    partial class fmSpace
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
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nwaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(284, 24);
            this.msTop.TabIndex = 1;
            this.msTop.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nwaToolStripMenuItem,
            this.sGToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.newToolStripMenuItem.Text = "New...";
            // 
            // nwaToolStripMenuItem
            // 
            this.nwaToolStripMenuItem.Name = "nwaToolStripMenuItem";
            this.nwaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nwaToolStripMenuItem.Text = "Nwa...";
            this.nwaToolStripMenuItem.Click += new System.EventHandler(this.nwaToolStripMenuItem_Click);
            // 
            // sGToolStripMenuItem
            // 
            this.sGToolStripMenuItem.Name = "sGToolStripMenuItem";
            this.sGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sGToolStripMenuItem.Text = "SG...";
            this.sGToolStripMenuItem.Click += new System.EventHandler(this.sGToolStripMenuItem_Click);
            // 
            // fmSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.msTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msTop;
            this.Name = "fmSpace";
            this.Text = "fmSpace";
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nwaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sGToolStripMenuItem;
    }
}