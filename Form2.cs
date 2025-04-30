using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Shua
{
    public partial class Form2 : Form
    {
        //public void Insertlogs(string User, string Message, string Date, string Time)
        //{
        //    Workbook wb = new Workbook();
        //    wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
        //    Worksheet sh = wb.Worksheets[1];

        //    int r = sh.Rows.Length;
        //    sh.Range[r, 1].Value = User;
        //    sh.Range[r, 2].Value = Message;
        //    sh.Range[r, 3].Value = Date;
        //    sh.Range[r, 4].Value = Time;

        //    wb.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");

        //    Insertlogs("Pantuan", "Add Student");
        //}
        public void insertData(string N, string G, string H, string FC, string S, string UN, string PW)
        {
            //int i = dataGridView1.Rows.Add();

            //dataGridView1.Rows[i].Cells[0].Value = N;
            //dataGridView1.Rows[i].Cells[1].Value = G;
            //dataGridView1.Rows[i].Cells[2].Value = H;
            //dataGridView1.Rows[i].Cells[3].Value = FC;
            //dataGridView1.Rows[i].Cells[4].Value = S;
            //dataGridView1.Rows[i].Cells[5].Value = UN;
            //dataGridView1.Rows[i].Cells[6].Value = PW;
        }

        public void Update(int ID, string N, string G, string H, string FC, string S, string UN, string PW)
        {
            dataGridView1.Rows[ID].Cells[0].Value = N;
            dataGridView1.Rows[ID].Cells[1].Value = G;
            dataGridView1.Rows[ID].Cells[2].Value = H;
            dataGridView1.Rows[ID].Cells[3].Value = FC;
            dataGridView1.Rows[ID].Cells[4].Value = S;
            dataGridView1.Rows[ID].Cells[5].Value = UN;
            dataGridView1.Rows[ID].Cells[6].Value = PW;
        }


        public Form2()
        {
            InitializeComponent();
            LoadExcelfile();
        }
        public void LoadExcelfile()
        {
            Workbook wb = new Workbook();
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[0];
            DataTable dt = sh.ExportDataTable();
            dataGridView1.DataSource = dt; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Workbook wb = new Workbook();
            wb.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx");
            Worksheet sh = wb.Worksheets[0];
            
            int r = dataGridView1.CurrentCell.RowIndex + 2;

            sh.DeleteRow(r);

            wb.SaveToFile(@"C:\Users\ACT-STUDENT\Desktop\Arrays shuaaa\Book1.xlsx", ExcelVersion.Version2016);

            DataTable dt = sh.ExportDataTable();
            dataGridView1.DataSource = dt;

            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{

            //    MessageBox.Show("Are you sure you want to delete this row?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    dataGridView1.Rows.Remove(row);
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Message!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;

            Form1 F1 = (Form1)Application.OpenForms["Form1"];

            F1.txtName.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();

            F1.lblTitle.Text = r.ToString();

            string gender = dataGridView1.Rows[r].Cells[1].Value.ToString();
            
            if( gender == "")
            {
                F1.radMale.Checked = true;
            }
            else
            {
                F1.radFemale.Checked = true;
            }

            string hobbies = dataGridView1.Rows[r].Cells[2].Value.ToString();

            string[] h = hobbies.Split(',');
            foreach (string val in h)
            {
                if (val == "Basketball")
                {
                    F1.chkBasketball.Checked = true;
                }

                if (val == "Volleybal")
                {
                    F1.chkVolleyball.Checked = true;    
                }

                if ( val == "Online Games")
                {
                    F1.chkOG.Checked = true;
                }
            }

            F1.cmbFavcolor.SelectedItem = dataGridView1.Rows[r].Cells[3].Value.ToString();

            F1.txtSaying.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            F1.txtUsername.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            F1.txtPassword.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            F1.btnUpdate.Visible = true;
            F1.btnAdd.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection(); 
            bool found = false; 

            try
            {
                
                if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text.Length < 1)
                {
                    MessageBox.Show("Please enter at least one letter  or more letter to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null &&
                        row.Cells[0].Value.ToString().StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        found = true; 
                        break; 
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Search not found !", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dataGridView1.ClearSelection();

            //try
            //{
            //    foreach (DataGridViewRow row in dataGridView1.Rows)
            //    {
            //        if (row.Cells[0].Value.ToString().Equals(txtSearch.Text))
            //        {
            //            row.Selected = true;
            //            break;
            //        }
            //        else
            //        {
            //            row.Selected = false;
            //        }
            //    }
            //}
            //catch(Exception) 
            //{
            //    MessageBox.Show("You've search not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
