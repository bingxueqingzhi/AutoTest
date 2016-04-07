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
using System.IO;
using System.Threading;

namespace 抓一批数据.Forms
{
    public partial class fmSetRsSg : Form
    {
        public fmSetRsSg()
        {
            InitializeComponent();
            this.cbxPowerUnit.SelectedIndex = 0;
            this.cbxFreqUnit.SelectedIndex = 0;
        }
        Socket st;
        /// <summary>
        /// 连接信号发生器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //连接
            IPAddress ip;
            if (IPAddress.TryParse(tbxIP.Text, out ip))
            {
                IPEndPoint ipep = new IPEndPoint(ip, 5025);
                TcpClient tc = new TcpClient();
                try
                {
                    tc.Connect(ipep);
                    this.st = tc.Client;
                    this.tbxIP.ReadOnly = true;
                    this.btnConnect.Enabled = false;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
                //读取RF状态
                byte[] buffer = new byte[1024 * 1024];
                EndPoint ep = this.st.RemoteEndPoint;
                this.st.Send(ComFunction.GetCmdBytes("output?"));
                int n = this.st.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
                string outputStatus = Encoding.ASCII.GetString(buffer, 0, n).Substring(0, n - 1);
                if (outputStatus == "1")
                {
                    this.btnRF.BackColor = Color.Green;
                }
                else
                {
                    this.btnRF.BackColor = Color.Red;
                }
                this.btnModGen.Enabled = true;
                this.btnModulation.Enabled = true;
                this.btnRF.Enabled = true;
            }
        }

        private void btnSetFreqPower_Click(object sender, EventArgs e)
        {
            this.btnSetFreqPower.BackColor = Color.Red;
            //设置频率
            this.st.Send(ComFunction.GetCmdBytes("source:frequency " + this.tbxFreq.Text + this.cbxFreqUnit.SelectedItem.ToString()));
            byte[] buffer = new byte[1024 * 1024];
            EndPoint ep = this.st.RemoteEndPoint;
            this.st.Send(ComFunction.GetCmdBytes("source:frequency?"));
            int n = this.st.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string s1 = (int.Parse(tbxFreq.Text) * Math.Pow(1000, cbxFreqUnit.SelectedIndex + 1)).ToString();
            string s2 = Encoding.ASCII.GetString(buffer, 0, n).Substring(0, n - 1);
            //设置功率
            this.st.Send(ComFunction.GetCmdBytes("source:power:power " + this.tbxPower.Text + this.cbxPowerUnit.SelectedItem.ToString()));
            //设置单位
            string unit;
            switch (this.cbxPowerUnit.SelectedIndex)
            {
                case 0:
                    unit = "dBuV";
                    break;
                case 1:
                    unit = "dBm";
                    break;
                default:
                    unit = "V";
                    break;
            }
            this.st.Send(ComFunction.GetCmdBytes("unit:power " + unit));
            this.st.Send(ComFunction.GetCmdBytes("source:power:power?"));
            n = this.st.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string p1 = tbxPower.Text;
            string p2 = Encoding.ASCII.GetString(buffer, 0, n).Substring(0, n - 1);
            if ((s1 == s2) && (p1 == p2))
            {
                this.btnSetFreqPower.BackColor = Color.Green;
            }
        }
        /// <summary>
        /// 打开/关闭RFoutput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRF_Click(object sender, EventArgs e)
        {
            if (this.btnRF.BackColor != Color.Green)
            {
                this.st.Send(ComFunction.GetCmdBytes("output 1"));
                byte[] buffer = new byte[1024 * 1024];
                EndPoint ep = this.st.RemoteEndPoint;
                this.st.Send(ComFunction.GetCmdBytes("output?"));
                int n = this.st.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
                string outputStatus = Encoding.ASCII.GetString(buffer, 0, n).Substring(0, n - 1);
                if (outputStatus == "1")
                {
                    this.btnRF.BackColor = Color.Green;
                }
            }
            else
            {
                this.st.Send(ComFunction.GetCmdBytes("output 0"));
                byte[] buffer = new byte[1024 * 1024];
                EndPoint ep = this.st.RemoteEndPoint;
                this.st.Send(ComFunction.GetCmdBytes("output?"));
                int n = this.st.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
                string outputStatus = Encoding.ASCII.GetString(buffer, 0, n).Substring(0, n - 1);
                if (outputStatus == "0")
                {
                    this.btnRF.BackColor = Color.Red;
                }
            }
        }

        private void tbxFreq_TextChanged(object sender, EventArgs e)
        {
            int n;
            this.btnSetFreqPower.Enabled = int.TryParse(this.tbxFreq.Text, out n) && int.TryParse(tbxPower.Text, out n);
        }

        private void tbxPower_TextChanged(object sender, EventArgs e)
        {
            int n;
            this.btnSetFreqPower.Enabled = int.TryParse(this.tbxFreq.Text, out n) && int.TryParse(tbxPower.Text, out n);
        }

    }
}
