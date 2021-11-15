using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929_form3
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

        private void Button1_Click(object sender, EventArgs e)
        {

            int F1 = 0;
            int F2 = 1;
            int space;

            for (int i = 0; i < 10; i++)
            {

                space = F1 + F2;
                lsbszamok.Items.Add(space);
                F1 = F2;
                F2 = space;

            }



        }
    }
}
