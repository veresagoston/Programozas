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

namespace _20211124
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
            
            lbxEredmeny.Items.Clear();
            
        }

        private void BtnFajlbaIras_Click(object sender, EventArgs e)
        {
            if (lbxEredmeny.Items.Count==0)
            {
                MessageBox.Show("Üres a listbox!");
            }
            else
            {
                foreach (var item in lbxEredmeny.Items)
                {
                    File.AppendAllText("Adatok.txt",item.ToString()+"\n");
                }
                MessageBox.Show("Sikeres kiiras!");
            }
        }

        private void BtnKiir_Click(object sender, EventArgs e)
        {
            if (txtDatum.Text!="" && txtKartya.Text!="" && txtKezdo.Text!="" && txtCel.Text!="")
            {
                try
                {
                    int kartya = int.Parse(txtKartya.Text);
                    string listboxba = txtDatum.Text + " " + txtKartya.Text + " " + txtKezdo.Text + " " + txtCel.Text;
                    lbxEredmeny.Items.Add(listboxba);

                    txtDatum.Text = "";
                    txtKartya.Text = "";
                    txtKezdo.Text = "";
                    txtCel.Text = "";
                    MessageBox.Show("Sikeres listába mentés! :) ", "Siker!");
                }
                catch (Exception)
                {
                    MessageBox.Show("A kártya szám nem jól adtad meg!", "Hiba!");
                }
                
            }
            else
            {
                MessageBox.Show("Minden mezőt tölts ki!", "Hiba!");
            }
            
        }

        private void BtnFajlolvas_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("lift.txt");
            foreach (var item in beolvas)
            {
                lbxEredmeny.Items.Add(item);
            }
        }

        private void BtnKeresés_Click(object sender, EventArgs e)
        {
            if (txtDatum.Text!="" || txtKartya.Text!="")
            {
                string datum = txtDatum.Text;
                string kartya = txtKartya.Text;
                List<string> listboxelem = new List<string>();
                foreach (var item in lbxEredmeny.Items)
                {
                    string[] darabok = item.ToString().Split(' ');
                    if (darabok[0].Contains(datum)&&darabok[1]==kartya)
                    {
                        listboxelem.Add(item.ToString());
                    }

                }
                lbxEredmeny.Items.Clear();
                foreach (var item in listboxelem)
                {
                    lbxEredmeny.Items.Add(item);
                }
            }
        }
    }
}
