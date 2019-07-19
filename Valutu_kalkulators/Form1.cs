using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valutu_kalkulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uzUSD_Click(object sender, EventArgs e)
        {
            decimal eiroDaudzums = decimal.Parse(this.ievaditieEur.Text);
            this.ievaditieUSD.Text = string.Format("{0:0.##}", (eiroDaudzums * 1.119845m));
            

        }

        private void uzEur_Click(object sender, EventArgs e)
        {
            decimal usdDaudzums = decimal.Parse(this.ievaditieUSD.Text);
            this.ievaditieEur.Text = string.Format("{0:0.##}",(usdDaudzums / 1.119845m));
        }
    }
}
