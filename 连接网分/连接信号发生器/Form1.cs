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
using Keysight.Visa;
using Ivi.Visa;
using System.IO;

namespace 连接信号发生器
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }
        IMessageBasedRawIO mio;
        IMessageBasedFormattedIO mfio;
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (IPAddress.TryParse(TbxIP.Text, out ip))//合法的IP地址
            {
                try//尝试连接
                {
                    mio = new TcpipSession(@"TCPIP0::" + ip.ToString() + "::inst0::INSTR", AccessModes.None, 5000).RawIO;
                    TbxLog.AppendText("Connected √" + Environment.NewLine);
                    BtnScreenShot.Enabled = true;
                    BtnCmd.Enabled = true;
                    this.BtnConnect.Enabled = false;
                    this.AcceptButton = this.BtnScreenShot;
                }
                catch (Exception err)
                {
                    TbxLog.AppendText(err.Message + Environment.NewLine);
                }
            }
            else
            {
                TbxLog.AppendText("Invalid IP" + Environment.NewLine);
            }
        }
        private void BtnScreenShot_Click(object sender, EventArgs e)
        {
            byte[] cmd = Encoding.ASCII.GetBytes("display:capture");
            mio.Write(cmd);
            cmd = Encoding.ASCII.GetBytes("MEMory:DATA? \"DISPLAY.BMP\"");
            mio.Write(cmd);
            TbxLog.AppendText("MEMory:DATA? \"DISPLAY.BMP\"" + Environment.NewLine);
            try
            {
                byte[] b = mio.Read();//读到原始数据
                byte[] buffer = MemDataResovler.GetRealBytes(b);//去掉安捷伦的头部
                SaveFileDialog sfd = new SaveFileDialog();//选择保存路径
                sfd.Filter = "BMP Files (*.bmp)|*.bmp";
                sfd.ShowDialog();
                string path = sfd.FileName;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fs.Write(buffer.ToArray(), 0, buffer.ToArray().Length);//写到硬盘
                }
            }
            catch (Exception err)
            {
                TbxLog.AppendText(err.Message + Environment.NewLine);
            }
        }

        private void BtnCmd_Click(object sender, EventArgs e)
        {
            FmCmd fc = new FmCmd(mio);
            fc.ShowDialog();
        }
    }
}
