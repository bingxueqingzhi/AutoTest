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

namespace 连接ZVL6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient tc;
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipa;
            if (!IPAddress.TryParse(TbxIP.Text, out ipa))
            {
                return;
            }
            tc = new TcpClient();
            tc.Connect(new IPEndPoint(ipa, 5025));
            byte[] buffer = new byte[30 * 1024 * 1024];
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(TcRecHandler), new TcRecObj(buffer, tc));
            BtnScreenShot.Enabled = true;
            BtnConnect.Enabled = false;
        }

        private void BtnScreenShot_Click(object sender, EventArgs e)
        {
            SendCMD("system:display:update on", tc);
            SendCMD("hcopy:item:all", tc);
            SendCMD("hcopy:device:language BMP", tc);
            SendCMD("hcopy:destination \"MMEM\"", tc);
            SendCMD("mmemory:name \"C:\\SS.BMP\"", tc);
            SendCMD("hcopy", tc);
            SendCMD("mmemory:data? \"C:\\SS.BMP\"", tc);
        }
        private void TcRecHandler(IAsyncResult iar)
        {
            byte[] agilentBytes = ((TcRecObj)iar.AsyncState).Buffer;
            byte[] buffer = MemDataResovler.GetRealBytes(agilentBytes);
            TcpClient tc = ((TcRecObj)iar.AsyncState).Tc;
            int n = tc.Client.EndReceive(iar);
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image Files (*.bmp)|*.bmp";
                sfd.RestoreDirectory = true;
                this.Invoke((Action)(() => { sfd.ShowDialog(); }));
                if (string.IsNullOrWhiteSpace(sfd.FileName))
                {
                    //return;
                }
                else
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fs.Write(buffer, 0, n);
                    }
                }
            }
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(TcRecHandler), new TcRecObj(buffer, tc));
        }
        private void SendCMD(string cmd, TcpClient tc)
        {
            tc.Client.Send(Encoding.ASCII.GetBytes(cmd + '\n'));
            //Thread.Sleep(1000);
        }
    }
}
