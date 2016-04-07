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
    public partial class fmSetRsNwa : Form
    {
        public fmSetRsNwa()
        {
            InitializeComponent();
            this.FuList = new List<Fu>(0);
            this.Wgbs = null;
        }
        public List<Fu> FuList { set; get; }
        public WuGuiBanShan Wgbs { set; get; }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTrace_Click(object sender, EventArgs e)
        {
            using (fmTrace t = new fmTrace())
            {
                t.ShowDialog();
                if (t.fu != null)
                {
                    this.FuList.Add(t.fu);
                    this.lbxTraceInfo.Items.Add(t.fu);
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(this.tbxMemName.Text)) && (!string.IsNullOrWhiteSpace(this.tbxStart.Text)) && (!string.IsNullOrWhiteSpace(this.tbxStop.Text)))
            {
                this.Wgbs = new WuGuiBanShan(this.tbxMemName.Text, this.tbxStart.Text, this.tbxStop.Text, this.FuList.ToArray());
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check you Fxxking input!");
            }
        }
    }
}
