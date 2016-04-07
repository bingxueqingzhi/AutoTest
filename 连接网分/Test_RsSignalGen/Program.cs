using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keysight.Visa;
using Ivi.Visa;

namespace Test_RsSignalGen
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpipSession ts = new TcpipSession("TCPIP::192.168.0.8::INSTR");
            IMessageBasedRawIO mrio = ts.RawIO;
            Console.WriteLine("Success!");
            Console.ReadLine();
        }
    }
}
