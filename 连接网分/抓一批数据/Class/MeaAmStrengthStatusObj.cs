using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抓一批数据.Forms;

namespace 抓一批数据.Class
{
    public class MeaAmStrengthStatusObj
    {
        public MeaAmStrengthStatusObj(delMeasAmStrength dmas, fmSetRsSa sa)
        {
            this.Dmas = dmas;
            this.Sa = sa;
        }
        public delMeasAmStrength Dmas { set; get; }
        public fmSetRsSa Sa { set; get; }
    }
}
