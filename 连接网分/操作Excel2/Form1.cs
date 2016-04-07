using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;

namespace 操作Excel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.DisplayAlerts = false;
            Workbooks wbs = app.Workbooks;
            Workbook wb = wbs.Add(true);
            Sheets ss = wb.Sheets;
            //Worksheet ws = ss[1];
            Worksheet ws = (Worksheet)ss.get_Item(1);
            ws.Cells[1, 1] = "1";
            //  下面这句话很重要, 有参数用于图片定位
            ws.Shapes.AddPicture(@"C:\Users\winter.liu\Desktop\Untitled.png", MsoTriState.msoFalse, MsoTriState.msoTrue, ((Range)ws.Cells[2, 1]).Left, ((Range)ws.Cells[2, 1]).Top, 683, 384);
            object o = ws.Shapes;
            wb.SaveAs(@"D:\5.xlsx");
            wb.Close();
            wbs.Close();
            app.Quit();
            this.label1.Text = "OK";
        }
    }
}
