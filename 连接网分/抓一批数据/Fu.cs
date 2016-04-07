using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抓一批数据
{
    /// <summary>
    /// 符咒
    /// </summary>
    public class Fu
    {
        /// <summary>
        /// TraceName 仅用于在窗口中显示
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 导出数据时用
        /// </summary>
        public string Title { set; get; }
        /// <summary>
        /// 用什么形式显示
        /// </summary>
        public Format FORMAT { set; get; }
        /// <summary>
        /// 测哪个S参数
        /// </summary>
        public Measures MEAS { set; get; }
        /// <summary>
        /// 画符!
        /// </summary>
        /// <param name="name">TraceName</param>
        /// <param name="title">Title</param>
        /// <param name="meas">测哪个S参数</param>
        public Fu(string name, string title, Measures meas, Format format)
        {
            this.Name = name;
            this.Title = title;
            this.MEAS = meas;
            this.FORMAT = format;
        }
        public override string ToString()
        {
            return this.Title + '\t' + this.Name + '\t' + this.MEAS.ToString() + '\t' + this.FORMAT.ToString();
        }
    }
}
