using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace 抓一批数据
{
    public enum Measures
    {
        S11 = 0,
        S21 = 1,
        S12 = 2,
        S22 = 3
    }
    public enum Format
    {
        MLIN,
        MLOG,
        PHAS,
        UPH,
        POL,
        SMIT,
        ISM,
        GDEL,
        REAL,
        IMAG,
        SWR,
        COMP,
        MAGN
    }
    /// <summary>
    /// 鬼道借法, 五鬼搬山!
    /// </summary>
    public class WuGuiBanShan
    {
        /// <summary>
        /// 测试的项目名标记, 仅用于标记记录
        /// </summary>
        public string[] Title { set; get; }
        /// <summary>
        /// 在网分上处于第几个窗口
        /// </summary>
        public string MemoryName { set; get; }
        /// <summary>
        /// 指定网分上的TraceName
        /// </summary>
        public string[] TraceName { set; get; }
        /// <summary>
        /// 测哪个参数?
        /// </summary>
        public Measures[] MEAS { set; get; }
        public Format[] FORMAT { set; get; }
        /// <summary>
        /// Start Frequency, eg: "50MHz"
        /// </summary>
        public string Start { set; get; }
        /// <summary>
        /// Stip Frequency, eg: "150MHz"
        /// </summary>
        public string Stop { set; get; }
        /// <summary>
        /// 用于标记这个对象的数据写在第几个Sheet
        /// </summary>
        public string SheetId { set; get; }
        /// <summary>
        /// 用于TCP通信的对象(必须是已连接的)
        /// </summary>
        public TcpClient Tc { set; get; }
        /// <summary>
        /// 每条trace占用一个元素, 截图放在最后一个元素
        /// </summary>
        public List<byte[]> TraceData { set; get; }
        public WuGuiBanShan(string memoryName, string start, string stop, string[] title, string[] traceName, Measures[] meas)
        {
            this.MemoryName = memoryName;
            this.Start = start;
            this.Stop = stop;
            this.Title = title;
            this.TraceName = traceName;
            this.MEAS = meas;
            this.TraceData = new List<byte[]>(0);
        }
        public WuGuiBanShan(string memoryName, string start, string stop, params Fu[] fu)
        {
            this.MemoryName = memoryName;
            this.Start = start;
            this.Stop = stop;
            this.Title = new string[fu.Length];
            for (int i = 0; i < fu.Length; i++)
            {
                this.Title[i] = fu[i].MEAS.ToString();
            }
            this.TraceName = new string[fu.Length];
            for (int i = 0; i < fu.Length; i++)
            {
                this.TraceName[i] = fu[i].Name;
            }
            this.MEAS = new Measures[fu.Length];
            for (int i = 0; i < fu.Length; i++)
            {
                this.MEAS[i] = fu[i].MEAS;
            }
            this.FORMAT = new Format[fu.Length];
            for (int i = 0; i < fu.Length; i++)
            {
                this.FORMAT[i] = fu[i].FORMAT;
            }
            this.TraceData = new List<byte[]>(0);
        }
        /// <summary>
        /// 五鬼搬山, 走你!
        /// </summary>
        /// <returns>是否创建成功</returns>
        public bool Initialize(TcpClient tc)
        {
            this.Tc = tc;
            //this.Tc2 = tc2;
            this.Tc.Client.Send(this.GetCmdBytes("memory:define \"" + this.MemoryName + "\""));//新建一个窗口
            this.Tc.Client.Send(this.GetCmdBytes("memory:select \"" + this.MemoryName + "\""));//切换到新建的这个窗口
            this.Tc.Client.Send(this.GetCmdBytes("sense:frequency:start " + this.Start));//设置start和stop频率
            this.Tc.Client.Send(this.GetCmdBytes("sense:frequency:stop " + this.Stop));
            this.Tc.Client.Send(this.GetCmdBytes("calculate1:format " + this.FORMAT));//设置此trace显示形式
            for (int i = 0; i < this.TraceName.Length; i++)
            {
                this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:define \"" + this.TraceName[i] + "\"," + this.MEAS[i].ToString()));//创建一个新的trace
                this.Tc.Client.Send(this.GetCmdBytes("display:window:trace:efeed \"" + this.TraceName[i] + "\""));//显示到当前窗口
                this.Tc.Client.Send(this.GetCmdBytes("calculate1:format " + this.FORMAT[i].ToString()));//设置此trace显示形式
            }
            this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:delete \"Trc1\""));
            //设置trace数据格式
            this.Tc.Client.Send(this.GetCmdBytes("format real,64"));
            this.Tc.Client.Send(this.GetCmdBytes("format:dexport:source fdata"));
            //设置截图参数
            this.Tc.Client.Send(this.GetCmdBytes("hcopy:item:all"));//截取全部元素
            this.Tc.Client.Send(this.GetCmdBytes("hcopy:device:language BMP"));//BMP格式
            this.Tc.Client.Send(this.GetCmdBytes("hcopy:destination \"MMEM\""));//先保存到设备硬盘上
            this.Tc.Client.Send(this.GetCmdBytes("mmemory:name \"C:\\SS.BMP\""));//设置设备上的路径
            this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:catalog?"));//查询trace是否创建成功
            byte[] buffer = new byte[10 * 1024 * 1024];//10MB缓存
            int n = this.Tc.Client.Receive(buffer);
            string str = Encoding.ASCII.GetString(buffer, 0, n);
            bool success = true;
            for (int i = 0; i < this.TraceName.Length; i++)//检查是否每个trace都创建成功了
            {
                success = success && str.Contains(this.TraceName[i]);
            }
            if (success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool pointReceived = false;
        bool imageReceived = false;
        /// <summary>
        /// 读取Trace数据并截图
        /// </summary>
        /// <param name="readFullTraceData">是否读取整个Trace数据, false=只读取Marker点数据</param>
        public void GetData(bool readFullTraceData)
        {
            if (this.TraceData != null)
            {
                this.TraceData.Clear();
            }
            this.Tc.Client.Send(this.GetCmdBytes("memory:select \"" + this.MemoryName + "\""));//切换到此窗口
            this.Tc.Client.Send(this.GetCmdBytes("format real,64"));
            this.Tc.Client.Send(this.GetCmdBytes("format:dexport:source fdata"));
            this.Tc.Client.Send(this.GetCmdBytes("initiate1:continuous off"));//关Sweep
            for (int i = 0; i < this.TraceName.Length; i++)
            {
                if (!readFullTraceData)//只读取Marker点数据
                {
                    this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:select \"" + this.TraceName[i] + "\""));//选择trace
                    List<byte> byteList = new List<byte>(0);
                    for (int marN = 1; marN < 10; marN++)//逐个读取一条trace上marker点
                    {
                        byte[] b = new byte[1024];
                        this.Tc.Client.Send(this.GetCmdBytes("calculate1:marker" + marN.ToString() + '?'));
                        int n = this.Tc.Client.Receive(b, b.Length, SocketFlags.None);
                        char markerStatus = Encoding.ASCII.GetString(b, 0, n)[0];//0=marker关闭, 1=marker打开
                        if (markerStatus == '1')
                        {
                            this.Tc.Client.Send(this.GetCmdBytes("calculate1:marker" + marN.ToString() + ":function:result?"));
                            n = this.Tc.Client.Receive(b, b.Length, SocketFlags.None);
                            string markerData = Encoding.ASCII.GetString(b, 0, n).Substring(0, n - 1);//频率,数据\n
                            markerData = markerData.Substring(markerData.IndexOf(',') + 1);
                            byteList.AddRange(Encoding.ASCII.GetBytes(markerData + ','));
                        }
                    }
                    byteList.AddRange(Encoding.ASCII.GetBytes("\n"));
                    this.TraceData.Add(byteList.ToArray());
                }
                else
                {
                    //逐个读取trace全部数据
                    byte[] buffer = new byte[10 * 1024 * 1024];//10MB缓冲
                    byte[] buf = new byte[1];
                    int n = 0;
                    while (!RawDataResolver.IsCompleteRawPacket(buffer, n))//检测是否是完整的包
                    {
                        this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:select \"" + this.TraceName[i] + "\""));//选择trace
                        this.Tc.Client.Send(this.GetCmdBytes("system:data:size all"));
                        this.Tc.Client.Send(this.GetCmdBytes("trace:data? ch1data"));//请求trace数据
                        n = this.Tc.Client.Receive(buffer, 0, buffer.Length, SocketFlags.None);//读取trace数据
                        buf = RawDataResolver.GetRealBytesHasNum(buffer, n);
                        while (!RawDataResolver.IsTraceData(buf))//检测是否是trace数据
                        {
                            this.Tc.Client.Send(this.GetCmdBytes("calculate1:parameter:select \"" + this.TraceName[i] + "\""));//选择trace
                            this.Tc.Client.Send(this.GetCmdBytes("trace:data? ch1data"));//请求trace数据
                            n = this.Tc.Client.Receive(buffer, 0, buffer.Length, SocketFlags.None);//读取trace数据
                            buf = RawDataResolver.GetRealBytesHasNum(buffer, n);
                        }
                    }
                    double[] points = RawDataResolver.RawTraceToDouble64(buf);
                    string result = "";
                    for (int j = 0; j < points.Length; j++)
                    {
                        result = result + points[j].ToString() + ',';
                    }
                    result = result + '\n';
                    buf = Encoding.ASCII.GetBytes(result);
                    this.TraceData.Add(buf);//放到返回值
                }
            }

            //获取截图
            this.Tc.Client.Send(this.GetCmdBytes("hcopy"));//截图
            int m = 0;
            byte[] buffer2 = new byte[10 * 1024 * 1024];
            ////this.Tc.Client.Send(this.GetCmdBytes("mmemory:data? \"C:\\SS.BMP\""));//请求读取截图到电脑
            while (!RawDataResolver.IsCompleteRawPacket(buffer2, m))
            {
                this.Tc.Client.Send(this.GetCmdBytes("mmemory:data? \"C:\\SS.BMP\""));//请求读取截图到电脑
                m = this.Tc.Client.Receive(buffer2, 0, buffer2.Length, SocketFlags.None);
            }
            this.Tc.Client.Send(this.GetCmdBytes("initiate1:continuous on"));//重新打开Sweep
            byte[] buf2 = RawDataResolver.GetRealBytesHasNum(buffer2, m);//截取有效的数据
            this.TraceData.Add(buf2);//放到返回值
        }
        public byte[] GetCmdBytes(string s)
        {
            return Encoding.ASCII.GetBytes(s + '\n');
        }
        public override string ToString()
        {
            return this.MemoryName + '\t' + this.TraceName.Length.ToString() + " traces\t" + this.Start + " to " + this.Stop;
        }
        private void ReadTracePoint(IAsyncResult iar)
        {
            int n = this.Tc.Client.EndReceive(iar);
            byte[] buffer = ((TcRecObj)iar.AsyncState).Buffer;
            byte[] buf = buffer.ToList().GetRange(0, n).ToArray();//截取有效的数据
            this.TraceData.Add(buf);//放到返回值
            this.pointReceived = true;
        }
        private void ReadTraceImage(IAsyncResult iar)
        {
            int n = this.Tc.Client.EndReceive(iar);
            byte[] buffer = ((TcRecObj)iar.AsyncState).Buffer;
            byte[] buf = RawDataResolver.GetRealBytesHasNum(buffer, n);//截取有效的数据
            this.TraceData.Add(buf);//放到返回值
            this.imageReceived = true;
        }
    }
}
