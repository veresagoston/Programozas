using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnkor_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(txtadat.Text);
            lblkerulet.Text = "Kör kerülete";
            lblterulet.Text = "Kör terület";
            double kerulet = 2 * sugar * Math.PI;
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            txtkerulet.Text = Convert.ToString(kerulet);
            txtterulet.Text = Convert.ToString(terulet);
        }

        private void Btngomb_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(txtadat.Text);
            lblkerulet.Text = "gömb felszine";
            lblterulet.Text = "gömb térfogat";
            double felszin = 4*Math.PI*Math.Pow(sugar, 2);
            double terfogat= 4*Math.PI/3*Math.Pow(sugar, 3);
            txtkerulet.Text = Convert.ToString(felszin);
            txtterulet.Text = Convert.ToString(terfogat);
        }
    }
}
