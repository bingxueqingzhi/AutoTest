using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace 操作Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.DisplayAlerts = false;
            Workbooks wbs = app.Workbooks;
            Workbook wb = wbs.Add(true);
            Sheets ss = wb.Sheets;
            //Worksheet ws = ss[1];
            Worksheet ws = (Worksheet)ss.get_Item(1);
            ws.Cells[1, 1] = "1";
            ws.Shapes.AddPicture(@"C:\Users\winter.liu\Desktop\Untitled.png", MsoTriState.msoFalse, MsoTriState.msoTrue, 10, 10, 1366, 768);
            //ws.Shapes.AddPicture(@"C:\Users\winter.liu\Desktop\Untitled.png", MsoTriState.msoFalse, MsoTriState.msoFalse, 0, 0, 100, 100);
            wb.SaveAs(@"D:\3.xlsx");
            app.Quit();
            Console.Read();
        }
    }
}
