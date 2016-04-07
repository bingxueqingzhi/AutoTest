using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace 导出marker数据
{
    public class TcRecObj
    {
        public TcpClient Tc { set; get; }
        public byte[] Buffer { set; get; }
        public TcRecObj(byte[] buffer, TcpClient tc)
        {
            this.Buffer = buffer;
            this.Tc = tc;
        }
    }
}
