using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desas
{
    public partial class Form1 : Form
    {
        public bool XTurn = true;
        public Form1()
        {
            InitializeComponent();
            GameOverButton.Visible = false;
        }
        public bool GameOver()
        {
            if (
                (TopLeftButton.Text == "X" && TopCenterButton.Text == "X" && TopRightButton.Text == "X") ||
                (TopLeftButton.Text == "X" && CenterButton.Text == "X" && BotomRightButton.Text == "X") ||
                (TopLeftButton.Text == "X" && MiddleLeftButton.Text == "X" && BottomLeftButton.Text == "X") ||
                (TopCenterButton.Text == "X" && CenterButton.Text == "X" && BottomCenterButton.Text == "X") ||
                (TopRightButton.Text == "X" && MiddleRightButton.Text == "X" && BotomRightButton.Text == "X") ||
                (MiddleLeftButton.Text == "X" && CenterButton.Text == "X" && MiddleRightButton.Text == "X") ||
                (BottomLeftButton.Text == "X" && BottomCenterButton.Text == "X" && BotomRightButton.Text == "X") ||
                (TopRightButton.Text == "X" && CenterButton.Text == "X" && BottomLeftButton.Text == "X"))
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "Player X has won!";
                return true;
            } else if ((TopLeftButton.Text == "O" && TopCenterButton.Text == "O" && TopRightButton.Text == "O") ||
                (TopLeftButton.Text == "O" && CenterButton.Text == "O" && BotomRightButton.Text == "O") ||
                (TopLeftButton.Text == "O" && MiddleLeftButton.Text == "O" && BottomLeftButton.Text == "O") ||
                (TopCenterButton.Text == "O" && CenterButton.Text == "O" && BottomCenterButton.Text == "O") ||
                (TopRightButton.Text == "O" && MiddleRightButton.Text == "O" && BotomRightButton.Text == "O") ||
                (MiddleLeftButton.Text == "O" && CenterButton.Text == "O" && MiddleRightButton.Text == "O") ||
                (BottomLeftButton.Text == "O" && BottomCenterButton.Text == "O" && BotomRightButton.Text == "O") ||
                (TopRightButton.Text == "O" && CenterButton.Text == "O" && BottomLeftButton.Text == "O"))
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "Player O has won!";
                return true;
            } else if (TopLeftButton.Text != "" && TopCenterButton.Text != "" && TopRightButton.Text != "" && 
                MiddleLeftButton.Text != "" && CenterButton.Text != "" && MiddleRightButton.Text != "" &&
                BottomLeftButton.Text != "" && BottomCenterButton.Text != "" && BottomLeftButton.Text != "")
            {
                GameOverButton.Visible = true;
                GameOverButton.Text = "It's a draw!";
                return true;
            }
            return false;
        }
        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && TopLeftButton.Text == "")
            {
                if (XTurn)
                {
                    TopLeftButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    TopLeftButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void TopCenterButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && TopCenterButton.Text == "")
            {
                if (XTurn)
                {
                    TopCenterButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    TopCenterButton.Text = "O";
                    XTurn = true;
                }
                
            }
            GameOver();
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && TopRightButton.Text == "")
            {
                if (XTurn)
                {
                    TopRightButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    TopRightButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void MiddleLeftButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && MiddleLeftButton.Text == "")
            {
                if (XTurn)
                {
                    MiddleLeftButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    MiddleLeftButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && CenterButton.Text == "")
            {
                if (XTurn)
                {
                    CenterButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    CenterButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void MiddleRightButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && MiddleRightButton.Text =="")
            {
                if (XTurn)
                {
                    MiddleRightButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    MiddleRightButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && BottomLeftButton.Text == "")
            {
                if (XTurn)
                {
                    BottomLeftButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    BottomLeftButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void BottomCenterButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && BottomCenterButton.Text == "")
            {
                if (XTurn)
                {
                    BottomCenterButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    BottomCenterButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void BotomRightButton_Click(object sender, EventArgs e)
        {
            if (!GameOver() && BotomRightButton.Text=="")
            {
                if (XTurn)
                {
                    BotomRightButton.Text = "X";
                    XTurn = false;
                }
                else
                {
                    BotomRightButton.Text = "O";
                    XTurn = true;
                }
            }
            GameOver();
        }

        private void GameOverButton_Click(object sender, EventArgs e)
        {
            GameOverButton.Visible = false;
            TopLeftButton.Text = "";
            TopCenterButton.Text = "";
            TopRightButton.Text = "";
            MiddleLeftButton.Text = "";
            CenterButton.Text = "";
            MiddleRightButton.Text = "";
            BottomLeftButton.Text = "";
            BottomCenterButton.Text = "";
            BottomLeftButton.Text = "";
            BotomRightButton.Text = "";
        }
    }
}
