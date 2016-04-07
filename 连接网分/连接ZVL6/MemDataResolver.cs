using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连接ZVL6
{
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
        /// 去掉安捷伦头部
        /// </summary>
        /// <param name="AgilentBytes">带头部的数据</param>
        /// <param name="Num">整个数据的字节数</param>
        /// <returns></returns>
        public static byte[] GetRealBytesHasNum(byte[] AgilentBytes, int Num)
        {
            List<byte> a = AgilentBytes.ToList();
            List<byte> b = a.GetRange(0, Num);
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
