using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace 用Socket连接SMB100A
{
    class Program
    {
        static TcpClient tc;
        static void Main(string[] args)
        {
            Console.WriteLine("Input IPAddress of SMB100A:");
            string ipStr = Console.ReadLine();
            IPAddress ipAdd;
            if (!IPAddress.TryParse(ipStr, out ipAdd))
            {
                return;
            }
            tc = new TcpClient();
            try
            {
                Console.WriteLine("Connecting...");
                tc.Connect(new IPEndPoint(ipAdd, 5025));
                Console.WriteLine("Success!");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed!");
                Console.ReadLine();
                return;
            }
            byte[] buffer = new byte[10 * 1024 * 1024];
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(TcAcbWriteLine), new TcObj(tc, buffer));
            ////Console.ReadLine();
            //SendCMD("*rst");
            ////Console.ReadLine();
            //SendCMD("inst:select nwa");
            ////Console.ReadLine();
            //SendCMD("calculate1:parameter:sdefine \"ch1tr1\",\"S11\"");
            ////Console.ReadLine();
            //SendCMD("calculate1:parameter:delete \"Trc1\"");
            ////Console.ReadLine();
            //SendCMD("display:window:trace:feed \"ch1tr1\"");
            ////Console.ReadLine();
            //SendCMD("frequency:start 500mhz");
            ////Console.ReadLine();
            //SendCMD("frequency:stop 3ghz");
            while (true)
            {
                string cmd = Console.ReadLine();
                SendCMD(cmd);
            }
        }
        static void TcAcbWriteLine(IAsyncResult iar)
        {
            byte[] buffer = ((TcObj)iar.AsyncState).Buffer;
            TcpClient tc = ((TcObj)iar.AsyncState).Tc;
            int n = tc.Client.EndReceive(iar);
            string returnStr = Encoding.ASCII.GetString(buffer, 0, n);
            double d = BitConverter.ToDouble(buffer, 6);
            if (!string.IsNullOrWhiteSpace(returnStr))
            {
                Console.WriteLine(returnStr);
            }
            tc.Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(TcAcbWriteLine), new TcObj(tc, buffer));
        }
        static void SendCMD(string cmd)
        {
            tc.Client.Send(Encoding.ASCII.GetBytes(cmd + '\n'));
        }
    }
}
