using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抓一批数据
{
    public static class ComFunction
    {
        public static byte[] GetCmdBytes(string cmd)
        {
            return Encoding.ASCII.GetBytes(cmd + '\n');
        }
    }
}
