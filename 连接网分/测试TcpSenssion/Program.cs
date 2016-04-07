using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Ivi.Visa;
using Keysight.Visa;
using System.Threading.Tasks;
using System.Threading;

namespace 测试TcpSenssion
{
    class Program
    {
        //TCPIP0::192.168.0.9::5025::SOCKET
        //TCPIP0::192.168.0.9::inst0::INSTR
        static void Main(string[] args)
        {
            TcpipSession ts = new TcpipSession(@"TCPIP0::192.168.0.9::inst0::INSTR");
            Console.WriteLine(ts.GetType().ToString());
            IMessageBasedFormattedIO mio = ts.FormattedIO;
            while (true)
            {
                string cmd = Console.ReadLine();
                mio.PrintfAndFlush(cmd);
                Console.WriteLine(@"Sending {0}", cmd);
                string[] res;
                try
                {
                    mio.Scanf("%s", out res);
                    Console.WriteLine();
                    //Console.WriteLine("Device Infomation:");
                    foreach (string s in res)
                    {
                        Console.WriteLine(s.Trim());
                    }
                    Console.WriteLine("Total Length {0}", res.Length);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    Console.WriteLine("Read failed");
                }
            }
        }
    }
}
