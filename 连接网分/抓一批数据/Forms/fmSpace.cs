using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抓一批数据.Forms;

namespace 抓一批数据
{
    public partial class fmSpace : Form
    {
        public fmSpace()
        {
            InitializeComponent();
        }

        private void nwaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmDeviceID did = new fmDeviceID();
            did.ShowDialog();
            fmMain m = new fmMain(did.DeviceID);
            m.MdiParent = this;
            m.Show();
        }

        private void sGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSetRsSg sg = new fmSetRsSg();
            sg.MdiParent = this;
            sg.Show();
        }

        private void sAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmSetRsSa sa = new fmSetRsSa();
            sa.MdiParent = this;
            sa.Show();
        }

        private void p1dBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmP_1dB p1db = new fmP_1dB();
            p1db.MdiParent = this;
            p1db.Show();
        }

        private void rdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmdIM3 dim3 = new fmdIM3();
            dim3.MdiParent = this;
            dim3.Show();
        }

        private void amStrengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAmSignalStrength ass = new fmAmSignalStrength();
            ass.MdiParent = this;
            ass.Show();
        }
    }
}
