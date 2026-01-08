using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Game.Properties;

namespace Tic_Tac_Game
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int win1 = 7;
        int win2 = 73;
        int win3 = 56;
        int win4 = 64 + 128 + 256;
        int win5 = 2 + 16 + 128;
        int win6 = 4 + 32 + 256;
        int win7 = 1 + 16 + 256;
        int win8 = 4 + 16 + 64;
        int Turns = 9;
        Button LastClick;
        void UpdateTurn()
        {
            if (lblPlayerTurn.Text == "Player 1")
                lblPlayerTurn.Text = "Player 2";
            else
                lblPlayerTurn.Text = "Player 1";
        }
        int Player1Result = 0;
        int Player2Result = 0;
        void UpdatePlayersChoices(ref int Player,Button ButtonName)
        {
            
            if (ButtonName == btn1)
                Player += Convert.ToInt32(btn1.Tag);
            else if (ButtonName == btn2)
                Player += Convert.ToInt32(btn2.Tag);
            else if (ButtonName == btn3)
                Player += Convert.ToInt32(btn3.Tag);
            else if (ButtonName == btn4)
                Player += Convert.ToInt32(btn4.Tag);
            else if (ButtonName == btn5)
                Player += Convert.ToInt32(btn5.Tag);
            else if (ButtonName == btn6)
                Player += Convert.ToInt32(btn6.Tag);
            else if (ButtonName == btn7)
                Player += Convert.ToInt32(btn7.Tag);
            else if (ButtonName == btn8)
                Player += Convert.ToInt32(btn8.Tag);
            else
                Player += Convert.ToInt32(btn9.Tag);
        }
        void UpdateChioce(Button ButtonName,Image Choice)
        {
          
        }
        bool PlayPlayer1(Button ButtonName)
        {
            ButtonName.Image = Resources.X;
            UpdatePlayersChoices(ref Player1Result,ButtonName);
            if (UpdateWinner(Player1Result))
                return true;
            else
                return false;
        }
        bool PlayPlayer2(Button ButtonName)
        {
            ButtonName.Image = Resources.O;
            UpdatePlayersChoices(ref Player2Result, ButtonName);
            if (UpdateWinner(Player2Result))
                return true;
            else
                return false;
        }
        bool UpdateWinner(int Player)
        {

            if ((Player & win1) == win1)
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win2) == win2)
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win3) == win3)
            {
                btn6.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win4) == win4)
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win5) == win5)
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win6) == win6)
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win7) == win7)
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                return true;
            }
            else if ((Player & win8) == win8)
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                return true;
            }
            return false;

        }
        bool GameOver = false;
       
        void PlayGame(Button ButtonName)
        {
            if(GameOver)
                return;
            if (ButtonName == LastClick)
            {
                MessageBox.Show("Wrong Choice","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (lblPlayerTurn.Text == "Player 1")
            {
                
                   
                    if (PlayPlayer1(ButtonName))
                    {
                        lblWinner.Text = "player1";
                        MessageBox.Show("player1 wins");
                        GameOver = true;
                        return;
                    }
               
            }
                else if (lblPlayerTurn.Text == "Player 2")
                {
            
                if (PlayPlayer2(ButtonName))
                    {
                    lblWinner.Text = "player2";
                    MessageBox.Show("player2 wins");
                    GameOver = true;
                    return;
                    }
                }
            // UpdatePlayersChoices(ButtonName);
            LastClick = ButtonName;
                Turns--;
            if(Turns==0)
            {
                lblWinner.Text = "Draw";
                GameOver = true;
                return;
            }
            UpdateTurn();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 8;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 350, 340, 350, 70);
            e.Graphics.DrawLine(Pen, 475, 340, 475, 70);


            // e.Graphics.DrawLine(Pen,580, 200, 250, 200);
            e.Graphics.DrawLine(Pen, 580, 150, 250, 150);
            e.Graphics.DrawLine(Pen, 580, 250, 250, 250);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PlayGame(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PlayGame(btn2);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PlayGame(btn5);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PlayGame(btn3);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PlayGame(btn6);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PlayGame(btn4);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PlayGame(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PlayGame(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PlayGame(btn9);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            btn1.Image = Resources.question_mark_96;
            btn2.Image = Resources.question_mark_96;
            btn3.Image = Resources.question_mark_96;
            btn4.Image = Resources.question_mark_96;
            btn5.Image = Resources.question_mark_96;
            btn6.Image = Resources.question_mark_96;
            btn7.Image = Resources.question_mark_96;
            btn8.Image = Resources.question_mark_96;
            btn9.Image = Resources.question_mark_96;

            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn9.BackColor = Color.Black;


            lblWinner.Text = "In Progress";
            lblPlayerTurn.Text = "Player 1";
            GameOver = false;
            Turns = 9;
            Player1Result = 0;
            Player2Result = 0;
        }
    }
}
