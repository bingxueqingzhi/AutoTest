using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace 导出marker数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string writeStr = "";
        TcpClient tc;
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipadd = IPAddress.Parse(TbxIP.Text);
            IPEndPoint ipep = new IPEndPoint(ipadd, 5025);
            this.tc = new TcpClient();
            try
            {
                this.tc.Connect(ipep);
                TbxLog.AppendText("Connected √" + Environment.NewLine);
            }
            catch (Exception err)
            {
                TbxLog.AppendText(err.Message + Environment.NewLine);
                TbxLog.AppendText("Connecting failed!" + Environment.NewLine);
                return;
            }
            BtnConnect.Enabled = false;
            BtnDownload.Enabled = true;
            byte[] buffer = new byte[30 * 1024 * 1024];
            this.tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(this.TcRecHandler), new TcRecObj(buffer, this.tc));
        }
        private void TcRecHandler(IAsyncResult iar)
        {
            TcpClient tc = ((TcRecObj)iar.AsyncState).Tc;
            byte[] buffer = ((TcRecObj)iar.AsyncState).Buffer;
            int n = tc.Client.EndReceive(iar);
            string recStr = Encoding.ASCII.GetString(buffer, 0, n).Trim();
            this.writeStr = this.writeStr + recStr + Environment.NewLine;
            WriteTbx(recStr, TbxLog);
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(TcRecHandler), new TcRecObj(buffer, tc));
        }
        private void SendCMD(string cmd)
        {
            this.tc.Client.Send(Encoding.ASCII.GetBytes(cmd + '\n'));
        }
        private void BeginSendCMD(string cmd)
        {
            byte[] cmdBytes = Encoding.ASCII.GetBytes(cmd + '\n');
            this.tc.Client.BeginSend(cmdBytes, 0, cmd.Length, SocketFlags.None, null, null);
        }
        public delegate void WriteTbxHandler(string txt, TextBox tbx);
        private void WriteTbx(string txt, TextBox tbx)
        {
            if (tbx.InvokeRequired)
            {
                tbx.Invoke(new WriteTbxHandler(WriteTbx), new object[] { txt, tbx });
            }
            else
            {
                tbx.AppendText(txt + Environment.NewLine);
            }
        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(TCMD);
            //t.IsBackground = true;
            //t.Start();
            this.BtnDownload.Enabled = false;
            this.BtnSaveCsv.Enabled = false;
            SendCMD("initiate1:continuous off");
            SendCMD("calculate1:marker1:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker2:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker3:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker4:function:result?");
            Thread.Sleep(500);
            SendCMD("initiate1:continuous on");
            this.BtnDownload.Enabled = true;
            this.BtnSaveCsv.Enabled = true;
        }
        void TCMD()
        {
            SendCMD("initiate1:continuous off");
            SendCMD("calculate1:marker1:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker2:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker3:function:result?");
            Thread.Sleep(500);
            SendCMD("calculate1:marker4:function:result?");
            Thread.Sleep(500);
            SendCMD("initiate1:continuous on");
        }

        private void BtnSaveCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.RestoreDirectory = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        fs.Write(Encoding.Unicode.GetBytes(this.writeStr), 0, Encoding.Unicode.GetBytes(this.writeStr).Length);
                    }
                }
            }
        }
    }
}
