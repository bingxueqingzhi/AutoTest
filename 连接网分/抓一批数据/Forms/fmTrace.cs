using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抓一批数据
{
    public partial class fmTrace : Form
    {
        public fmTrace()
        {
            InitializeComponent();
            this.fu = null;
        }
        public Fu fu { set; get; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(this.tbxTraceName.Text)) && (!string.IsNullOrWhiteSpace(this.tbxTraceTitle.Text)) && this.cbxMeasure.SelectedIndex != -1)
            {
                this.fu = new Fu(this.tbxTraceName.Text, this.tbxTraceTitle.Text, (Measures)this.cbxMeasure.SelectedIndex, (Format)this.cbxFormat.SelectedIndex);
                this.Close();
            }
        }
    }
}
