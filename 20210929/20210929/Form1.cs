using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int szam1 = Convert.ToInt32(txbelsoszam.Text);
            int szam2 = Convert.ToInt32(txbmasodikszam.Text);
            int nagyobb;
            int kissebb;
            int oszto = 1;

            kissebb = szam2;
            nagyobb = szam1;






            if (szam1 > szam2)
            {

                nagyobb = szam1;
                kissebb = szam2;

            }
            else if (szam1 == szam2)
            {

                txboszto.Text = Convert.ToString(szam1);

            }
            else if (szam1 < szam2)
            {

                nagyobb = szam2;
                kissebb = szam1;

            }

            for (int i = 1; i < kissebb+1; i++)
            {

                if (kissebb % i == 0 && nagyobb % i == 0)
                {

                    oszto = i;

                }

            }


            txboszto.Text = Convert.ToString(oszto);











        }
    }
}
