using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesasPretDatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOverButton.Visible = false;
        }
        bool PlayersTurn = true;
        public bool GameOver()
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
              (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
              (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
              (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
              (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
              (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
              (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
              (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "Player X has won!";
                return true;
            }
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
              (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
              (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
              (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
              (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
              (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
              (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
              (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "Player O has won!";
                return true;
            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
              button4.Text != "" && button5.Text != "" && button6.Text != "" &&
              button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "It's a draw!";
                return true;
            }
            return false;
        }



        private void GameOverButton_Click(object sender, EventArgs e)
        {
            GameOverButton.Visible = false;
            PlayersTurn = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
        Random r = new Random();
        
        public void ComputersMove()
        {
            while (!PlayersTurn && !GameOver())
            {
                int guess = r.Next(1, 9 + 1);
                switch (guess)
                {
                    case 1:
                        if(button1.Text == "")
                        {
                            button1.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 2:
                        if (button2.Text == "")
                        {
                            button2.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 3:
                        if (button3.Text == "")
                        {
                            button3.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 4:
                        if (button4.Text == "")
                        {
                            button4.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 5:
                        if (button5.Text == "")
                        {
                            button5.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 6:
                        if (button6.Text == "")
                        {
                            button6.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 7:
                        if (button7.Text == "")
                        {
                            button7.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 8:
                        if (button8.Text == "")
                        {
                            button8.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                    case 9:
                        if (button9.Text == "")
                        {
                            button9.Text = "O";
                            PlayersTurn = true;
                        }
                        break;
                }
                     
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PlayersTurn && button1.Text =="")
            {
                button1.Text = "X";
                PlayersTurn = false;
                
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button2.Text == "")
            {
                button2.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button3.Text == "")
            {
                button3.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button4.Text == "")
            {
                button4.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button5.Text == "")
            {
                button5.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button6.Text == "")
            {
                button6.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button7.Text == "")
            {
                button7.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button8.Text == "")
            {
                button8.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (PlayersTurn && button9.Text == "")
            {
                button9.Text = "X";
                PlayersTurn = false;
            }
            GameOver();
            ComputersMove();
            GameOver();
        }
    }
}
