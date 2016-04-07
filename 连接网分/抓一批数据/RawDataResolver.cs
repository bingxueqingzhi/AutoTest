using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抓一批数据
{
    class RawDataResolver
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
        /// <summary>
        /// 检查是否是完整的Raw数据
        /// </summary>
        /// <param name="RawPacket">Raw IP包</param>
        /// <param name="Num">总共有多少个有效字节(包括头部)</param>
        /// <returns></returns>
        public static bool IsCompleteRawPacket(byte[] RawPacket, int Num)
        {
            if (RawPacket[0] == 35 && RawPacket[Num - 1] == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double[] RawTraceToDouble64(byte[] RawTrace)
        {
            List<double> point = new List<double>(0);
            for (int i = 0; i + 8 < RawTrace.Length; i += 8)
            {
                double p = BitConverter.ToDouble(RawTrace, i);
                point.Add(p);
            }
            return point.ToArray();
        }
        public static bool IsTraceData(byte[] RawTraceData)
        {
            if ((RawTraceData.Length - 1) % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
