using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Shua
{
    public partial class Form3 : Form
    {

        Form4 f4 = new Form4();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Workbook wb = new Workbook();
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[0];
            int row = sh.Rows.Length;
            bool log = false;


            for (int i =2; i<= row; i++)
            {
                if (sh.Range[i, 6].Value == txtUsername.Text && sh.Range[i, 7].Value == txtPassword.Text)
                {
                    f4.pictureBox1.Image = Image.FromFile(@"" + sh.Range[i, 9].Value.ToString());
                    log = true;
                    break;
                }
                else
                {
                    log = false;
                }
            }

            if(log == true)
            {
                MessageBox.Show("Successfully login");                
                f4.Show();
                this.Hide();              
            }
            else
            {
                if (!log)
                {
                    MessageBox.Show("Invalid login!");
                }
            }
        }
    }
}
