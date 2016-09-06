using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ivi.Visa.Interop;

namespace TestFSVwithVISA
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "+12.5423576E+12";
            double d = double.Parse(s, System.Globalization.NumberStyles.Float);
        }
    }
}
