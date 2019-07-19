using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        string enteredNumber = "";
        string operation = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        void numberClicked(int num)
        {
            // nospiesto ciparu pievieno ievadlaukam
            
            
            if (isOperationClicked || EnteredTextBox.Text == "0")
            {
                EnteredTextBox.Text = "";
            }
            EnteredTextBox.Text += num.ToString();
            isOperationClicked = false;
            // ja pirms cipara nospiesta darbība, tad notīra ievadlauku
            // ja ievadlaukā ir cipars nulle, tad notīra ievadlauku
        }
        void operationClicked(string op)
        {
            isOperationClicked = true;
            
            if (string.IsNullOrEmpty(enteredNumber))
            {
                enteredNumber = EnteredTextBox.Text;
                operation = op;

            } else
            {
                
                equalsClicked();
                
            }
            
            // ja enterednumber nav definets:
            //attēlotais skaitlis jasaglabā kā enterednumber
            // izvēlētā darbība jāsaglabā kā operation

            // ja enterednumber ir definēts 
            //izpilda equalsclicked
        }
        void equalsClicked()
        {

            // pārvērš enteredNumber uz int
            
            switch (operation)
            {
                case "+":
                    EnteredTextBox.Text = (int.Parse(enteredNumber) + int.Parse(EnteredTextBox.Text)).ToString();
                    
                    break;
                case "-":
                    EnteredTextBox.Text = (int.Parse(enteredNumber) - int.Parse(EnteredTextBox.Text)).ToString();
                    
                    break;
                case "*":
                    EnteredTextBox.Text = (int.Parse(enteredNumber) * int.Parse(EnteredTextBox.Text)).ToString();
                    
                    break;
                case "/":
                    EnteredTextBox.Text = (int.Parse(enteredNumber) / int.Parse(EnteredTextBox.Text)).ToString();
                    
                    break;
            }


            enteredNumber = EnteredTextBox.Text;
            
            
            
            
            // pārvērš ievadlauka skaitli uz int
            // aprēķina rezultātu starp abiem skaitļiem, izmantojot operation darbību
            // attēlo rezultātu ievadlaukā
            
            
        }
        void clearClicked()
        {
            // notīra visu mainīgo vērtības un ievadlaukā attēloto
            
            EnteredTextBox.Clear();
            enteredNumber = "";
            operation = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearClicked();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            numberClicked(0);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            numberClicked(1);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            numberClicked(2);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            numberClicked(3);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            numberClicked(4);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            numberClicked(5);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            numberClicked(6);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            numberClicked(7);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            numberClicked(8);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            numberClicked(9);
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            operationClicked("/");
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            operationClicked("*");
             
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            operationClicked("-");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            operationClicked("+");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            equalsClicked();
        }
    }
}
