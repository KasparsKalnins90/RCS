using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skaitlu_Spele
{
    public partial class Form1 : Form
    {
         Random r = new Random();
        int minamais;
        public Form1()
        {
            InitializeComponent();
            this.pazinojums.Visible = false;
            minamais = r.Next(1, 1000 + 1);
        }

        private void minet_Click(object sender, EventArgs e)
        {
            this.pazinojums.Visible = true;
            

            if (int.Parse(minejums.Text) == minamais)
            {
                this.pazinojums.Text = "Apsveicam! Tu uzminēji!";
                this.minejums.Text = "";
            } else if (int.Parse(minejums.Text) < minamais)
            {
                this.pazinojums.Text = "Mēģini lielāku skaitli";
                this.minejums.Text = "";
            }
            else if (int.Parse(minejums.Text) > minamais)
            {
                this.pazinojums.Text = "Mēģini mazāku skaitli";
                this.minejums.Text = "";
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            minamais = r.Next(1, 1000 + 1);
            this.pazinojums.Visible = false;

        }
        
    }
}
