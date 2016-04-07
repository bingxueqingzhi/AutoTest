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
using System.Threading;

namespace 抓一批数据
{
    public partial class fmScanCurrentSettings : Form
    {
        public fmScanCurrentSettings()
        {
            InitializeComponent();
        }
        TcpClient Tc;
        public fmScanCurrentSettings(TcpClient tc)
            : this()
        {
            this.Tc = tc;
        }
        public WuGuiBanShan[] WGBS { set; get; }
        private void fmScanCurrentSettings_Shown(object sender, EventArgs e)
        {
            this.tbxLog.AppendText("Scaning memory on " + this.Tc.Client.RemoteEndPoint.ToString() + Environment.NewLine);
            byte[] buffer = new byte[1024 * 1024];
            //1查询有多少个Memory
            this.SendCMD("memory:catalog?");
            int n = this.Tc.Client.Receive(buffer, 0, buffer.Length, SocketFlags.None);
            string mem = Encoding.ASCII.GetString(buffer, 0, n);
            mem = mem.Substring(1, mem.Length - 3);
            string[] mems = mem.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            this.tbxLog.AppendText(mems.Length.ToString() + " Memory Found." + Environment.NewLine);
            //2为每个Memory构造对象
            List<WuGuiBanShan> wgbsList = new List<WuGuiBanShan>(0);
            foreach (string m in mems)
            {
                //2.1查询每个Memory有多少个Trace
                this.SendCMD("memory:select " + "\"" + m + "\"");
                this.tbxLog.AppendText("Scaning " + m+ "..." + Environment.NewLine);
                this.SendCMD("calculate:parameter:catalog?");
                n = this.Tc.Client.Receive(buffer, buffer.Length, SocketFlags.None);
                string fu = Encoding.ASCII.GetString(buffer, 0, n);
                fu = fu.Substring(1, fu.Length - 3);
                string[] fus = fu.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);//这个字符串包含了TraceName和Measure
                //2.2为每个Trace构造对象
                List<string> fuNameList = new List<string>(0);//TraceNameList
                List<Measures> fuMeasList = new List<Measures>(0);//TraceMeasureList
                List<Format> fuFormatList = new List<Format>(0);//TraceFormatList
                //2.3把字符串里的TraceName和Measure分开
                for (int i = 0; i < fus.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        fuNameList.Add(fus[i]);
                        this.SendCMD("calculate1:parameter:select \"" + fus[i] + '\"');
                        this.SendCMD("calculate1:format?");
                        n = this.Tc.Client.Receive(buffer, buffer.Length, SocketFlags.None);
                        string format = Encoding.ASCII.GetString(buffer, 0, n);
                        fuFormatList.Add((Format)Enum.Parse(typeof(Format), format));
                    }
                    else
                    {
                        fuMeasList.Add((Measures)Enum.Parse(typeof(Measures), fus[i]));
                    }
                }
                this.tbxLog.AppendText(fuNameList.Count + " Trace Found" + Environment.NewLine);
                //2.4构造每个Trace
                List<Fu> fuList = new List<Fu>(0);
                for (int i = 0; i < fuNameList.Count; i++)
                {
                    fuList.Add(new Fu(fuNameList[i], fuNameList[i], fuMeasList[i], fuFormatList[i]));
                }
                //2.5获取Memory的Start频率
                this.tbxLog.AppendText("Reading Frequency..." + Environment.NewLine);
                this.SendCMD("sense:frequency:start?");
                n = this.Tc.Client.Receive(buffer, buffer.Length, SocketFlags.None);
                string start = Encoding.ASCII.GetString(buffer, 0, n);
                start = start.Substring(0, start.Length - 1);
                //2.6获取Memory的Stop频率
                this.SendCMD("sense:frequency:stop?");
                n = this.Tc.Client.Receive(buffer, buffer.Length, SocketFlags.None);
                string stop = Encoding.ASCII.GetString(buffer, 0, n);
                stop = stop.Substring(0, stop.Length - 1);
                //2.7构造Memory对象
                WuGuiBanShan wgbs = new WuGuiBanShan(m, start, stop, fuList.ToArray());
                wgbs.Tc = this.Tc;
                wgbsList.Add(wgbs);
            }
            this.WGBS = wgbsList.ToArray();
            this.tbxLog.AppendText("Done!" + Environment.NewLine);
            Thread.Sleep(3000);
            this.Close();
        }
        private void SendCMD(string cmd)
        {
            string Cmd = cmd + '\n';
            this.Tc.Client.Send(Encoding.ASCII.GetBytes(Cmd));
        }
    }
}
