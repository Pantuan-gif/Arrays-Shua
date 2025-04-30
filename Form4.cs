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
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            Active a = new Active();
            a.Show();
            this.Hide();
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {
            InActive ia = new InActive();
            ia.Show();
            this.Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Logs L = new Logs();
            L.Show();
            this.Hide();

        //Whatwthats
        }
    }
}
