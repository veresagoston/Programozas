using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210929_7feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnszamitas_Click(object sender, EventArgs e)
        {
            int m = int.Parse(nagyobbik.Text);
            int n = int.Parse(kissebbik.Text);
            for (int i = 1; i <= n; i++)
            {
                if (m%i==0 && n%i==0)
                {
                    txteredmeny.Text = Convert.ToString(i);
                }
            }
        }
    }
}
