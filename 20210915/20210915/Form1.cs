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
            lblmuvelet.Text = "Összeadás művelet";
            try
            {
                int adat1 = Convert.ToInt32(txbadat1.Text);
                int adat2 = Convert.ToInt32(txbadat2.Text);
                int eredmeny;

                eredmeny = adat1 + adat2;

                txberedmeny.Text = Convert.ToString(eredmeny);
            }
            catch (Exception)
            {
                MessageBox.Show("nem jó számot adtál meg");
               
            }
            

                

            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnkivonas_Click(object sender, EventArgs e)
        {
            try
            {
                lblmuvelet.Text = "Kivonás művelet";
                int adat1 = Convert.ToInt32(txbadat1.Text);
                int adat2 = Convert.ToInt32(txbadat2.Text);
                int eredmeny;

                eredmeny = adat1 - adat2;

                txberedmeny.Text= Convert.ToString(eredmeny);
            }
            catch (Exception)
            {
                MessageBox.Show("nem jó számot adtál meg");
                
            }
            
        }

        private void Btnszorzas_Click(object sender, EventArgs e)
        {

            try
            {
                lblmuvelet.Text = "Szorzás művelet";
                int adat1 = Convert.ToInt32(txbadat1.Text);
                int adat2 = Convert.ToInt32(txbadat2.Text);
                int eredmeny;

                eredmeny = adat1 * adat2;

                txberedmeny.Text = Convert.ToString(eredmeny);
            }
            catch (Exception)
            {
                MessageBox.Show("nem jó számot adtál meg");
            
            }
            

        }
    }
}
