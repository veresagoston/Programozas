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

namespace _20211117_form
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



        private void LbxEredmeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDatum.Text != "" && txtHely.Text != "" && txtPont.Text != "" && txtSport.Text != "")
            {
                try
                {
                    int helyezes = int.Parse(txtHely.Text);
                    int pontszam = int.Parse(txtPont.Text);
                    string szoveg = txtDatum.Text + "\t" + txtSport.Text + "\t" + txtHely.Text + "\t" + txtPont.Text;
                    lbxEredmeny.Items.Add(szoveg);
                    txtDatum.Text = "";
                    txtHely.Text = "";
                    txtPont.Text = "";
                    txtSport.Text = "";
                    MessageBox.Show("Sikeres listába töltés!", "Siker!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Nem számot adtál meg!", "Hiba");
                }
            }
            else
            {
                MessageBox.Show("Minden Adatott adjál meg!", "hiba");
            }
        }

        private void BtnFajl_Click(object sender, EventArgs e)
        {
            if (lbxEredmeny.Items.Count != 0)
            {
                foreach (var item in lbxEredmeny.Items)
                {
                    File.AppendAllText("Forras.txt", item + "\n");
                }
                lbxEredmeny.Items.Clear();
                MessageBox.Show("A fájlba írás megtörtént!", "Szuper!");
            }
            else
            {
                MessageBox.Show("Üres a listbox!", "Hiba!");
            }
        }



        private void BtnFeltolt_Click(object sender, EventArgs e)
        {
            var beolvas = File.ReadAllLines("prost.csv", Encoding.UTF8);
            for (int i = 1; i < beolvas.Length; i++)
            {
                lbxEredmeny.Items.Add(beolvas[i]);
            }
            MessageBox.Show("Sikeres feltöltés!", "LETS GO!");
            string[] db;
            foreach (var item in beolvas)
            {
                db = item.Split('\t');
                if (!lbxEredmeny.Items.Contains(db[1]))
                {
                    lbxEredmeny.Items.Add(db[1]);
                }
            }
        }

        private void BtnMegjelen_Click(object sender, EventArgs e)
        {
            var datum = txtDatum.Text;
            List<string> ujlista = new List<string>();
            foreach (string item in lbxEredmeny.Items)
            {
                if (!item.Contains(datum))
                {
                    ujlista.Add(item);
                }
            }
            lbxEredmeny.Items.Clear();
            foreach (var item in ujlista)
            {
                lbxEredmeny.Items.Add(item);
            }
        }
    }
}
