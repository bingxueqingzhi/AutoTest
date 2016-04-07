using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace 连接ZVL6
{
    public class TcRecObj
    {
        public byte[] Buffer { get; set; }
        public TcpClient Tc { get; set; }
        public TcRecObj(byte[] buffer, TcpClient tc)
        {
            this.Buffer = buffer;
            this.Tc = tc;
        }
    }
}
