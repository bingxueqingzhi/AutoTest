using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace 用Socket连接SMB100A
{
    class TcObj
    {
        public TcpClient Tc { set; get; }
        public byte[] Buffer { set; get; }
        public TcObj(TcpClient tc, byte[] buffer)
        {
            this.Tc = tc;
            this.Buffer = buffer;
        }
    }
}
