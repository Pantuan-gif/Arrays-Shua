using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Shua
{
    class Mylogs
    {       
        public void Insertlogs(string User, string Message)
        {       
            Workbook wb = new Workbook();
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[1];

            int r = sh.Rows.Length + 1;

            sh.Range[r, 1].Value = User;
            sh.Range[r, 2].Value = Message;
            sh.Range[r, 3].Value = DateTime.Now.ToString("MM/dd/yyyy");
            sh.Range[r, 4].Value = DateTime.Now.ToString("hh:mm:ss:tt");
            wb.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
        }
    }
}
