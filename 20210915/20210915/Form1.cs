using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210915
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnosszeadas_Click(object sender, EventArgs e)
        {
            int a,b,c;
            a = Convert.ToInt32(txtadat1.Text);
            b = Convert.ToInt32(txtadat2.Text);
            c = a + b;
            txteredmeny.Text = c.ToString();
            lblmuvelet.Text = "Müvelet: összeadás";
            lblmuvelet.Visible = true;




        }

        private void Btnkivonas_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtadat1.Text);
            b = Convert.ToInt32(txtadat2.Text);
            c = a - b;
            txteredmeny.Text = c.ToString();
            lblmuvelet.Text = "Müvelet: Kivonás";
            lblmuvelet.Visible = true;

        }

        private void Btnszorzas_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtadat1.Text);
            b = Convert.ToInt32(txtadat2.Text);
            c = a * b;
            txteredmeny.Text = c.ToString();
            lblmuvelet.Text = "Müvelet: Szorzás";
            lblmuvelet.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lblmuvelet_Click(object sender, EventArgs e)
        {
            

        }
    }
}
