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
    public partial class fmDeviceID : Form
    {
        public fmDeviceID()
        {
            InitializeComponent();
        }
        public string DeviceID { set; get; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DeviceID = tbxID.Text;
            this.Close();
        }
    }
}
