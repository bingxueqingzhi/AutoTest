using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连接信号发生器
{
    /// <summary>
    /// 加上安捷伦头部或去掉头部
    /// </summary>
    public class MemDataResovler
    {
        /// <summary>
        /// 去掉安捷伦头部
        /// </summary>
        /// <param name="AgilentBytes">带头部的数据</param>
        /// <returns></returns>
        public static byte[] GetRealBytes(byte[] AgilentBytes)
        {
            List<byte> b = AgilentBytes.ToList();
            byte[] l = new byte[1];
            l[0] = b[1];
            int length = Convert.ToInt32(Encoding.ASCII.GetString(l));
            length += 2;
            b.RemoveRange(0, length);
            return b.ToArray();
        }
        /// <summary>
        /// 加上安捷伦头部
        /// </summary>
        /// <param name="RealBytes">不带头部的数据</param>
        /// <returns></returns>
        public static byte[] GetAgilentBytes(byte[] RealBytes)
        {
            List<byte> realBytes = RealBytes.ToList();
            int length = realBytes.Count;
            int lengthOfLength = length.ToString().Length;
            realBytes.InsertRange(0, Encoding.ASCII.GetBytes(length.ToString()));
            realBytes.InsertRange(0, Encoding.ASCII.GetBytes(lengthOfLength.ToString()));
            realBytes.InsertRange(0, Encoding.ASCII.GetBytes("#"));
            return realBytes.ToArray();
        }
    }
}
