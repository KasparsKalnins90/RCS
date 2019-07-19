using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprekini_Forma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void videjais_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
            decimal videjais = ((pirmais + otrais) / 2);
            rezultats.Text =videjais.ToString();
            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";

        }

        private void summa_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
            decimal summa = (pirmais + otrais);
            rezultats.Text = summa.ToString();
            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";

        }

        private void starpiba_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
            decimal starpiba = (pirmais - otrais);
            rezultats.Text = starpiba.ToString();
            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";
        }

        private void reizinajums_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
            decimal reizinajums = (pirmais * otrais);
            rezultats.Text = reizinajums.ToString();
            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";

        }

        private void maksimala_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
           if(pirmais > otrais)
            {
                rezultats.Text = pirmais.ToString();
            }
           else
            {
                rezultats.Text = otrais.ToString();
            }
            
            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";
        }

        private void minimalais_Click(object sender, EventArgs e)
        {
            decimal pirmais = decimal.Parse(this.pirmaisIevaditais.Text);
            decimal otrais = decimal.Parse(this.otraisIevaditais.Text);
            if (pirmais < otrais)
            {
                rezultats.Text = pirmais.ToString();
            }
            else
            {
                rezultats.Text = otrais.ToString();
            }

            this.pirmaisIevaditais.Text = "";
            this.otraisIevaditais.Text = "";
        }
    }
}
