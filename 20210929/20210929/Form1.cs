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

        private void Btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnevszak_Click(object sender, EventArgs e)
        {
            int szam = Convert.ToInt32(txtadat.Text);
            switch(szam)
            {
                case 1:
                    lblszoveg.Text = ("Tél");
                    break;
                case 2:
                    lblszoveg.Text = ("Tél");
                    break;
                case 3:
                    lblszoveg.Text = ("Tavasz");
                    break;
                case 4:
                    lblszoveg.Text = ("Tavasz");
                    break;
                case 5:
                    lblszoveg.Text = ("Tavasz");
                    break;
                case 6:
                    lblszoveg.Text = ("Nyár");
                    break;
                case 7:
                    lblszoveg.Text = ("Nyár");
                    break;
                case 8:
                    lblszoveg.Text = ("Nyár");
                    break;
                case 9:
                    lblszoveg.Text = ("Ősz");
                    break;
                case 10:
                    lblszoveg.Text = ("Ősz");
                    break;
                case 11:
                    lblszoveg.Text = ("Ősz");
                    break;
                case 12:
                    lblszoveg.Text = ("Tél");
                    break;
                
                    
            }
        }
    }
}
