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
    }
}
