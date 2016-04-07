using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抓一批数据.Class
{
    public class RsSgStatus
    {
        public string Freq { set; get; }
        public string Power { set; get; }
        public bool ModGenOn { set; get; }
        public bool ModulationOn { set; get; }
        public bool RfOn { set; get; }
        public RsSgStatus()
        { }
        /// <summary>
        /// 创建一个信号源状态实例
        /// </summary>
        /// <param name="freq">频率</param>
        /// <param name="power">功率</param>
        /// <param name="modGenOn"></param>
        /// <param name="modulationOn"></param>
        /// <param name="rfOn"></param>
        public RsSgStatus(string freq, string power, bool modGenOn, bool modulationOn, bool rfOn)
        {
            this.Freq = freq;
            this.Power = power;
            this.ModGenOn = modGenOn;
            this.ModulationOn = modulationOn;
            this.RfOn = rfOn;
        }
    }
}
