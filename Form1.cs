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
    public partial class Form1 : Form
    {
        string[] Student = new string[5];

        Form2 f2 = new Form2(); 
        
        int i = 0;

        Workbook wb = new Workbook();

        Mylogs logs = new Mylogs();

        //Form4 f4 = new Form4();

        //Form1 f1 = new Form1();

        public Form1()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string data = "";
            string gender = "";
            string hobbies = "";

            data += txtName.Text ;

            if (radFemale.Checked)
            {
                gender = radFemale.Text + ",";
            }
            else if (radMale.Checked)
            {
                gender = radMale.Text + ",";
            }

            if (chkBasketball.Checked)
            {
                hobbies += chkBasketball.Text + ",";
            }
            if (chkOG.Checked)
            {
                hobbies += chkOG.Text + ",";
            }
            if (chkVolleyball.Checked)
            {
                hobbies += chkVolleyball.Text + ",";
            }

            data += cmbFavcolor.Text;
            data += txtSaying.Text;
            data += txtUsername.Text;
            data += txtPassword.Text;   

            Student[i] = data;

            i++;

            //lblTitle.Text = "Enter Value student " + (i + 1);
           
            f2.insertData(txtName.Text,gender, hobbies , cmbFavcolor.Text, txtSaying.Text,txtUsername.Text, txtPassword.Text);           
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[0];

            int r = sh.Rows.Length + 1;

            sh.Range[r,1].Value = txtName.Text;
            sh.Range[r,2].Value = gender;
            sh.Range[r,3].Value = hobbies;
            sh.Range[r,4].Value = cmbFavcolor.Text;
            sh.Range[r, 5].Value = txtSaying.Text;
            sh.Range[r, 6].Value = txtUsername.Text;
            sh.Range[r, 7].Value = txtPassword.Text;
            //Status
            sh.Range[r, 9].Value = txtProfilePic.Text;


            wb.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx", ExcelVersion.Version2016);
            logs.Insertlogs("Pantuan",  "Add Student");
            DataTable dt = sh.ExportDataTable();

            f2.dataGridView1.DataSource = dt;   

            txtName.Text = string.Empty;
            txtSaying.Text = string.Empty;
            radFemale.Checked = false;
            radMale.Checked = false;
            chkBasketball.Checked = false;
            chkOG.Checked = false;
            chkVolleyball.Checked = false;
            cmbFavcolor.SelectedIndex = -1;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;    
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string values = "";
            for (int c = 0; c <= i; c++)
            {
                values += "[" + c + "] = " + Student[c] + "\n";
            }
            //MessageBox.Show(values);
            f2.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.BringToFront();
            btnAdd.SendToBack();

            string data = "";
            string gender = "";
            string hobbies = "";

            data += txtName.Text;

            if (radFemale.Checked)
            {
                gender = radFemale.Text + ",";
            }
            else if (radMale.Checked)
            {
                gender = radMale.Text + ",";
            }

            if (chkBasketball.Checked)
            {
                hobbies += chkBasketball.Text + ",";
            }
            if (chkOG.Checked)
            {
                hobbies += chkOG.Text + ",";
            }
            if (chkVolleyball.Checked)
            {
                hobbies += chkVolleyball.Text + ",";
            }

            data += cmbFavcolor.Text;
            data += txtSaying.Text;
            data += txtUsername.Text;
            data += txtPassword.Text;

            Student[i] = data;

            i++;

            /*lblTitle.Text = "Enter Value student " + (i + 1);*/

            f2.Update(Convert.ToInt32(lblTitle.Text), txtName.Text, gender, hobbies, cmbFavcolor.Text, txtSaying.Text, txtUsername.Text, txtPassword.Text);
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[0];

            wb.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx", ExcelVersion.Version2016);
            logs.Insertlogs("Pantuan", "Update Student");            
            //DataTable dt = sh.ExportDataTable();
            //f2.dataGridView1.DataSource = dt;
            int r = f2.dataGridView1.CurrentCell.RowIndex + 2;
            //Novo bogo
            //Mga kakampi kong bobo
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                txtProfilePic.Text = d.FileName;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
