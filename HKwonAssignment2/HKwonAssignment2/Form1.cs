using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// Assignment 2: Tic-Tac-Toe
//
// HKwonAssignment2
//  By: Haeryun Kwon (Irene)
//  Date Created: 10.08.2017
//

namespace HKwonAssignment2
{
    public partial class Form1 : Form
    {
        // Initialize variables
        string oWinMsg = "O Win!";
        string xWinMsg = "X Win!";
        string drawMsg = "Draw!";

        public Form1()
        {
            InitializeComponent();

            btn1.Click += new System.EventHandler(ClickedButton);
            btn2.Click += new System.EventHandler(ClickedButton);
            btn3.Click += new System.EventHandler(ClickedButton);
            btn4.Click += new System.EventHandler(ClickedButton);
            btn5.Click += new System.EventHandler(ClickedButton);
            btn6.Click += new System.EventHandler(ClickedButton);
            btn7.Click += new System.EventHandler(ClickedButton);
            btn8.Click += new System.EventHandler(ClickedButton);
            btn9.Click += new System.EventHandler(ClickedButton);
        }

        /****************************************************************************
                                        Form Buttons
         ****************************************************************************/
        public void ClickedButton(object sender, EventArgs e)
        {
            // Initialize variables
            string btnAllText = btn1.Text + btn2.Text + btn3.Text + btn4.Text + btn5.Text + btn6.Text + btn7.Text + btn8.Text + btn9.Text;

            // If the concatenated texts or all buttons are empty, it starts with 'x'.
            // Also, need to check whether a clicked button is empty or not.
            if (btnAllText == "" && (sender as Button).Text == "") // 1st turn
            {
                (sender as Button).Text = "x";
                (sender as Button).Image = Properties.Resources.X;
            }

            if (btnAllText == "x" && (sender as Button).Text == "") // 2nd turn
            {
                (sender as Button).Text = "o";
                (sender as Button).Image = Properties.Resources.O;
            }

            if (btnAllText.Length == 2 && (sender as Button).Text == "") // 3rd turn
            {
                (sender as Button).Text = "x";
                (sender as Button).Image = Properties.Resources.X;
            }

            if (btnAllText.Length == 3 && (sender as Button).Text == "") // 4th turn
            {
                (sender as Button).Text = "o";
                (sender as Button).Image = Properties.Resources.O;
            }

            if (btnAllText.Length == 4 && (sender as Button).Text == "") // 5th turn
            {
                (sender as Button).Text = "x";
                (sender as Button).Image = Properties.Resources.X;
            }

            if (btnAllText.Length == 5 && (sender as Button).Text == "") // 6th turn
            {
                (sender as Button).Text = "o";
                (sender as Button).Image = Properties.Resources.O;
            }

            if (btnAllText.Length == 6 && (sender as Button).Text == "") // 7th turn
            {
                (sender as Button).Text = "x";
                (sender as Button).Image = Properties.Resources.X;
            }

            if (btnAllText.Length == 7 && (sender as Button).Text == "") // 8th turn
            {
                (sender as Button).Text = "o";
                (sender as Button).Image = Properties.Resources.O;
            }

            if (btnAllText.Length == 8 && (sender as Button).Text == "") // 9th turn
            {
                (sender as Button).Text = "x";
                (sender as Button).Image = Properties.Resources.X;
            }

            // After every player-turn, it should check if there is a winner.
            CheckWinner();
        }

        /****************************************************************************
                                      Check for a Win
         ****************************************************************************/

        public void CheckWinner()
        {
            if (btn1.Text + btn2.Text + btn3.Text == "ooo" || btn4.Text + btn5.Text + btn6.Text == "ooo" || btn7.Text + btn8.Text + btn9.Text == "ooo" ||
                btn1.Text + btn4.Text + btn7.Text == "ooo" || btn2.Text + btn5.Text + btn8.Text == "ooo" || btn3.Text + btn6.Text + btn9.Text == "ooo" ||
                btn1.Text + btn5.Text + btn9.Text == "ooo" || btn3.Text + btn5.Text + btn7.Text == "ooo")
            {
                MessageBox.Show(oWinMsg);
                AskNewGame();
            }

            else if (btn1.Text + btn2.Text + btn3.Text == "xxx" || btn4.Text + btn5.Text + btn6.Text == "xxx" || btn7.Text + btn8.Text + btn9.Text == "xxx" ||
                btn1.Text + btn4.Text + btn7.Text == "xxx" || btn2.Text + btn5.Text + btn8.Text == "xxx" || btn3.Text + btn6.Text + btn9.Text == "xxx" ||
                btn1.Text + btn5.Text + btn9.Text == "xxx" || btn3.Text + btn5.Text + btn7.Text == "xxx")
            {
                MessageBox.Show(xWinMsg);
                AskNewGame();
            }

            else
            {
                CheckDraw();
            }
        }

        /****************************************************************************
                                    Check for a Draw
         ****************************************************************************/
        private void CheckDraw()
        {
            if (btn1.Text.Length > 0 & btn2.Text.Length > 0 & btn3.Text.Length > 0 &
                btn4.Text.Length > 0 & btn5.Text.Length > 0 & btn6.Text.Length > 0 &
                btn7.Text.Length > 0 & btn8.Text.Length > 0 & btn9.Text.Length > 0)
            {
                MessageBox.Show(drawMsg);
                AskNewGame();
            }
        }

        /****************************************************************************
                                      Ask New Game
         ****************************************************************************/

        private void AskNewGame()
        {
            // Show a message box asking whether a user want to continue the game or not.
            DialogResult newGame = MessageBox.Show("New Game?", "Tic Tac Toe", MessageBoxButtons.YesNo);

            // If 'Yes'
            if(newGame == DialogResult.Yes)
            {
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";
                btn9.Text = "";

                btn1.Image = null;
                btn2.Image = null;
                btn3.Image = null;
                btn4.Image = null;
                btn5.Image = null;
                btn6.Image = null;
                btn7.Image = null;
                btn8.Image = null;
                btn9.Image = null;
            }

            else // If 'No'
            {
                Application.Exit();
            }
        }
    }
}
