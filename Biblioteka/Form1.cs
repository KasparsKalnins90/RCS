using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> biblioteka = new Dictionary<string, int>();
       
        public Form1()
        {
            InitializeComponent();
           
            biblioteka.Add("Moby Dick", 3);
            biblioteka.Add("Bībele", 6);
            biblioteka.Add("The Hobbit", 2);
            biblioteka.Add("Silence of the lambs", 1);

            IzvaditSarakstu();


        }
       
        
        private void PanemtGramatu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < biblioteka.Count; i++) {
                if (NosaukumaTextBox.Text == biblioteka.Keys.ElementAt(i))
                {
                    if (biblioteka[NosaukumaTextBox.Text] == 0)
                    {
                        GramatuSarakstsTextBox.Text = "Grāmata vairs nav pieejama";
                    }
                    else
                    {
                        biblioteka[NosaukumaTextBox.Text] -= 1;
                        IzvaditSarakstu();
                    }
                }
                    }
            
        }

        private void IesniegtGramatu_Click(object sender, EventArgs e)
        {
            bool foundBoook = false;
            if (NosaukumaTextBox.Text != "")
            {
                for (int i = 0; i < biblioteka.Count; i++)
                {
                    if (NosaukumaTextBox.Text == biblioteka.Keys.ElementAt(i))
                    {
                        biblioteka[NosaukumaTextBox.Text] += 1;
                        foundBoook = true;
                    }
                }
                if (!foundBoook)
                {
                    PievienotGramatu();
                }
                IzvaditSarakstu();
            }
        }
        public void IzvaditSarakstu()
        {
            //string saraksts = "";
            GramatuSarakstsTextBox.Text = "";
            for (int i = 0; i < biblioteka.Count; i++)
            {
                GramatuSarakstsTextBox.Text +=  "Grāmata: " + biblioteka.Keys.ElementAt(i) + " Skaits: "+  biblioteka.Values.ElementAt(i) + "\r\n";

            }
            //GramatuSarakstsTextBox.Text = saraksts;
        }
        public void PievienotGramatu()
        {
            biblioteka.Add(NosaukumaTextBox.Text, 1);
        }
    }
}
