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

namespace 抓一批数据.Forms
{
    public enum SaSweepType
    {
        SWE = 0,
        AUTO = 1,
        FFT = 3
    }
    public partial class fmSetRsSa : Form
    {
        public fmSetRsSa()
        {
            InitializeComponent();
        }
        public fmSetRsSa(Socket s)
            : this()
        {
            this.S = s;
            this.S.ReceiveBufferSize = 1024 * 1024;
        }
        public Socket S { set; get; }
        public void SetPowerUnit(PowerUnit unit)
        {
            this.S.Send(ComFunction.GetCmdBytes("unit:power " + unit.ToString()));
        }
        public void PreAmpOn(bool on)
        {
            if (on)
            {
                this.S.Send(ComFunction.GetCmdBytes("INPut:GAIN:STATe on"));
            }
            else
            {
                this.S.Send(ComFunction.GetCmdBytes("INPut:GAIN:STATe off"));
            }
        }
        public void SetFreq(string start, string stop)
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:span:full"));
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:start " + start));
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:stop " + stop));
        }
        public void SetFreq(string center)
        {
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:center " + center));
        }
        public void SetFreqSpan(string center, string span)
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:span:full"));
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:center " + center));
            this.S.Send(ComFunction.GetCmdBytes("sense:frequency:span " + span));
        }
        public float[] GetTrace()
        {
            if (this.S == null)
            {
                return null;
            }
            this.S.Send(ComFunction.GetCmdBytes("format real,32"));
            this.S.Send(ComFunction.GetCmdBytes("trace:data? trace1"));
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024 * 1024];
            int n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            List<byte> bufferList = buffer.ToList().GetRange(0, n);
            if (!RawDataResolver.IsCompleteRawPacket(bufferList.ToArray(), n))
            {
                return null;
            }
            List<byte> traceByte = RawDataResolver.GetRealBytes(bufferList.ToArray()).ToList();
            List<float> traceData = new List<float>(0);
            for (int i = 0; i < traceByte.Count - 4; i += 4)
            {
                float f = BitConverter.ToSingle(traceByte.ToArray(), i);
                traceData.Add(f);
            }
            return traceData.ToArray();
        }
        /// <summary>
        /// 设置RBW
        /// </summary>
        /// <param name="rbw">string型rbw</param>
        public void SetRBW(string rbw)
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("sense:bandwidth:resolution " + rbw));
        }
        /// <summary>
        /// 设置RBW
        /// </summary>
        /// <param name="rbw">int型rbw</param>
        public void SetRBW(int rbw)
        {
            this.SetRBW(rbw.ToString());
        }
        /// <summary>
        /// 设置VBW
        /// </summary>
        /// <param name="vbw">string型vbw</param>
        public void SetVBW(string vbw)
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("sense:bandwidth:video " + vbw));
        }
        /// <summary>
        /// 设置VBW
        /// </summary>
        /// <param name="vbw">int型vbw</param>
        public void SetVBW(int vbw)
        {
            this.SetVBW(vbw.ToString());
        }
        /// <summary>
        /// 开始or结束持续sweep
        /// </summary>
        /// <param name="on">true=on, false=off</param>
        public void ContinuousSweep(bool on)
        {
            if (this.S == null)
            {
                return;
            }
            if (on)
            {
                this.S.Send(ComFunction.GetCmdBytes("initiate:continuous on"));
            }
            else
            {
                this.S.Send(ComFunction.GetCmdBytes("initiate:continuous off"));
            }
        }
        /// <summary>
        /// 进行一次SingleSweep
        /// </summary>
        public void SingleSweep()
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("initiate;*wai"));
        }
        /// <summary>
        /// 获取SweepTime
        /// </summary>
        /// <returns></returns>
        public double GetSweepTime()
        {
            if (this.S == null)
            {
                return -1;
            }
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024];
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:time?"));
            int n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string timeStr = Encoding.ASCII.GetString(buffer, 0, n);
            string[] timeStrSplit = timeStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            timeStr = string.Join("", timeStrSplit);
            return double.Parse(timeStr);
        }
        /// <summary>
        /// 获取SweepCount
        /// </summary>
        /// <returns></returns>
        public int GetSweepCount()
        {
            if (this.S == null)
            {
                return -1;
            }
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024];
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:count?"));
            int n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string countStr = Encoding.ASCII.GetString(buffer, 0, n);
            string[] countStrSplit = countStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            countStr = string.Join("", countStrSplit);
            return int.Parse(countStr);
        }
        public void SetSweepCount(int sweepCount)
        {
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:count " + sweepCount.ToString()));
        }
        /// <summary>
        /// 获取SweepPoint
        /// </summary>
        /// <returns></returns>
        public int GetSweepPoints()
        {
            if (this.S == null)
            {
                return -1;
            }
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024];
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:points?"));
            int n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string countStr = Encoding.ASCII.GetString(buffer, 0, n);
            string[] countStrSplit = countStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            countStr = string.Join("", countStrSplit);
            return int.Parse(countStr);
        }
        public void SetSweepPoints(int numOfPoints)
        {
            if (this.S == null)
            {
                return;
            }
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:points " + numOfPoints.ToString()));
        }
        /// <summary>
        /// 连接频谱仪
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipadd;
            if (IPAddress.TryParse(this.tbxIp.Text, out ipadd))
            {
                TcpClient tc = new TcpClient();
                tc.Connect(ipadd, 5025);
                this.S = tc.Client;
                btnRBW.Enabled = btnVBW.Enabled = true;
            }
        }

        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            float[] trace = this.GetTrace();
        }
        public void AllMarkerOff()
        {
            this.S.Send(ComFunction.GetCmdBytes("calculate:marker:aoff"));
        }
        /// <summary>
        /// 控制Marker开关
        /// </summary>
        /// <param name="n">Marker编号</param>
        /// <param name="on">开或关</param>
        public void MarkerControl(int n, bool on)
        {
            if (on)
            {
                this.S.Send(ComFunction.GetCmdBytes("calculate:marker" + n.ToString() + " on"));
            }
            else
            {
                this.S.Send(ComFunction.GetCmdBytes("calculate:marker" + n.ToString() + " off"));
            }
        }
        /// <summary>
        /// 控制Marker的X轴值
        /// </summary>
        /// <param name="n">Marker编号</param>
        /// <param name="freq">频率</param>
        public void SetMarkerX(int n, Int64 freq)
        {
            this.S.Send(ComFunction.GetCmdBytes("calculate:marker" + n.ToString() + ":X " + freq.ToString()));
        }
        public double GetMarkerY(int n)
        {
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024];
            this.S.Send(ComFunction.GetCmdBytes("calculate:marker" + n.ToString() + ":Y?"));
            int x = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string yStr = Encoding.ASCII.GetString(buffer, 0, x - 1);
            return double.Parse(yStr);
        }
        public void SetRefLevel(double level, PowerUnit unit)
        {
            this.S.Send(ComFunction.GetCmdBytes("display:trace:y:rlevel " + level.ToString() + unit.ToString()));
        }
        public void SetAttenuation(int att)
        {
            this.S.Send(ComFunction.GetCmdBytes("input:attenuation " + att.ToString() + "dB"));
        }
        public int GetAttenuation()
        {
            EndPoint ep = this.S.RemoteEndPoint;
            byte[] buffer = new byte[1024];
            this.S.Send(ComFunction.GetCmdBytes("input:attenuation?"));
            int x = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
            string attStr = Encoding.ASCII.GetString(buffer, 0, x - 1);
            return int.Parse(attStr);
        }
        public void SetSweepType(SaSweepType type)
        {
            this.S.Send(ComFunction.GetCmdBytes("sense:sweep:type " + type.ToString()));
        }
        public void Reset()
        {
            this.S.Send(ComFunction.GetCmdBytes("*RST"));
        }
        public void SetModeSpectrum()
        {
            this.S.Send(ComFunction.GetCmdBytes("inst san"));
        }
        public void DisplayUpdate(bool on)
        {
            char s;
            if (on)
            {
                s = '1';
            }
            else
            {
                s = '0';
            }
            this.S.Send(ComFunction.GetCmdBytes("system:display:update " + s));
        }
        /// <summary>
        /// 获取截图
        /// </summary>
        /// <returns></returns>
        public byte[] GetScreenShot()
        {
            bool notComplete = true;
            byte[] buffer = new byte[1024 * 1024 * 10];
            List<byte> dList = new List<byte>();
            int n = 0;
            while (notComplete)
            {
                EndPoint ep = this.S.RemoteEndPoint;
                List<byte> bList = new List<byte>(0);
                this.S.Send(ComFunction.GetCmdBytes("hcopy:item:all"));
                this.S.Send(ComFunction.GetCmdBytes("hcopy:device:language png"));
                this.S.Send(ComFunction.GetCmdBytes(@"MMEM:NAME 'C:\ss.png'"));
                this.S.Send(ComFunction.GetCmdBytes(@"hcopy:destination 'MMEM'"));
                this.S.Send(ComFunction.GetCmdBytes("hcopy"));
                this.S.Send(ComFunction.GetCmdBytes(@"mmemory:data? 'C:\ss.bmp'"));
                //n = this.S.ReceiveFrom(buffer, buffer.Length, SocketFlags.None, ref ep);
                NetworkStream ns = new NetworkStream(this.S, FileAccess.ReadWrite, true);
                n = ns.Read(buffer, 0, buffer.Length);
                while (buffer[n - 1] != 10)
                {
                    bList.AddRange(buffer.ToList().GetRange(0, n));
                    n = ns.Read(buffer, 0, buffer.Length);
                }
                notComplete = !RawDataResolver.IsCompleteRawPacket(bList.ToArray(), bList.Count);
            }
            return RawDataResolver.GetRealBytesHasNum(buffer, n);
        }
    }
}
