using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace 抓一批数据
{
    public class TcRecObj
    {
        public byte[] Buffer { set; get; }
        public TcpClient Tc { set; get; }
        public string StrPath { set; get; }
        public string DId { set; get; }
        public TcRecObj(byte[] buffer, TcpClient tc)
        {
            this.Buffer = buffer;
            this.Tc = tc;
        }
        public TcRecObj(byte[] buffer, TcpClient tc, string strPath, string dId)
            : this(buffer, tc)
        {
            this.StrPath = strPath;
            this.DId = dId;
        }
    }
}
