using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20211208_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            txtHivasszam.Text = "";
            txtNev.Text = "";
            txtOra.Text = "";
            txtPerc.Text = "";
        }

        private void BtnFajlba_Click(object sender, EventArgs e)
        {
            if (txtOra.Text != "" && txtPerc.Text != "" && txtHivasszam.Text != "" && txtNev.Text != "")
            {

                try
                {
                    int ora = int.Parse(txtOra.Text);
                    int perc = int.Parse(txtPerc.Text);
                    int hivas = int.Parse(txtHivasszam.Text);
                    string nev = txtNev.Text;
                    string szoveg = ora + ";" + perc + ";" + hivas + ";" + nev;
                    lbxEredmeny.Items.Add(szoveg);
                    MessageBox.Show("Sikeres Feltöltés!", "Szuper!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem adtál meg adatot!");
                    throw;
                }
            }
            if (lbxEredmeny.Items.Count!=0)
            {
                foreach (var item in lbxEredmeny.Items)
                {
                    File.AppendAllText("Forras.txt", item + ";");
                }
                lbxEredmeny.Items.Clear();
                MessageBox.Show("Megtörtént a fájlba írás!", "Siker!");
            }
        }


    }
}
