using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Piemeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.labelInfo.Visible = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.labelInfo.Visible = true;
            labelInfo.Text = String.Format("Tevi sauc {0} {1}", inputName.Text, inputSurname.Text);
            inputName.Text = "";
            inputSurname.Text = "";
        }
    }
}
