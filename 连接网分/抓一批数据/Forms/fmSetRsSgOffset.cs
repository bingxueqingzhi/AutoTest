using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace 抓一批数据.Forms
{
    public partial class fmSetRsSgOffset : Form
    {
        public fmSetRsSgOffset()
        {
            InitializeComponent();
        }
        private Socket S { set; get; }
        public fmSetRsSgOffset(Socket s)
            : this()
        {
            this.S = s;
            this.cbxUnit.SelectedIndex = 0;
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024 * 1024];
            //看看现在的Offset是多少
            this.S.Send(ComFunction.GetCmdBytes("source:frequency:offset?"));
            int n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string res = Encoding.ASCII.GetString(buffer, 0, n);
            res = res.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)[0];
            double offset = double.Parse(res);
            if (offset != 0)
            {
                if (!((offset / 1000000).ToString().Contains('.')))
                {
                    this.cbxUnit.SelectedIndex = 2;
                    this.tbxOffSet.Text = (offset / 1000000).ToString();
                }
                else if (!((offset / 1000).ToString().Contains('.')))
                {
                    this.cbxUnit.SelectedIndex = 1;
                    this.tbxOffSet.Text = (offset / 1000).ToString();
                }
                else
                {
                    this.cbxUnit.SelectedIndex = 0;
                    this.tbxOffSet.Text = offset.ToString();
                }
            }
            else
            {
                this.tbxOffSet.Text = "0";
            }
        }
        /// <summary>
        /// 减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinu_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(this.tbxOffSet.Text, out n))
            {
                n--;
                this.S.Send(ComFunction.GetCmdBytes("source:frequency:offset " + n.ToString() + this.cbxUnit.SelectedItem.ToString()));
                this.tbxOffSet.Text = n.ToString();
            }
        }
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(this.tbxOffSet.Text, out n))
            {
                n++;
                this.S.Send(ComFunction.GetCmdBytes("source:frequency:offset " + n.ToString() + this.cbxUnit.SelectedItem.ToString()));
                this.tbxOffSet.Text = n.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(this.tbxOffSet.Text, out n))
            {
                this.S.Send(ComFunction.GetCmdBytes("source:frequency:offset " + n.ToString() + this.cbxUnit.SelectedItem.ToString()));
                this.btnOK.BackColor = Color.Green;
                this.Close();
            }
            else
            {
                this.btnOK.BackColor = Color.Red;
            }
        }

    }
}
