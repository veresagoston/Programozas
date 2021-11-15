using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnszamol_Click(object sender, EventArgs e)
        {

            try
            {

                int a = Convert.ToInt32(txba.Text);
                int b = Convert.ToInt32(txbb.Text);
                int c = Convert.ToInt32(txbc.Text);

                if (a > 0 && b > 0 && c > 0)
                {

                    int V = a * b * c;
                    int A = 2 * a * b + 2 * a * c + 2 * b * c;


                    txbv.Text = Convert.ToString(V);
                    txbaeredmeny.Text = Convert.ToString(A);

                }
                else 
                {

                    MessageBox.Show("negatív számmal nem lehet számolni!");
                    txba.Text = "";
                    txbb.Text = "";
                    txbc.Text = "";

                }


                

            }
            catch (Exception)
            {

                MessageBox.Show("nem megfelelő értéket adtál meg!");
                

            }



        }

        private void Button1_Click(object sender, EventArgs e)
        {

            txba.Text = "";
            txbb.Text = "";
            txbc.Text = "";
            txbaeredmeny.Text = "";
            txbv.Text = "";

        }
    }
}
