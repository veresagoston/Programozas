﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929_form
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
            int szam = Convert.ToInt32(txbszam.Text);
            double gyok= Math.Sqrt(szam);

            gyok = Math.Round(gyok, 4);



            txbgyok.Text = Convert.ToString(gyok);

        }
    }
}
