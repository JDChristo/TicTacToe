using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIcTacToe_WF
{
    public partial class Form1 : Form
    {
        private const string aboutText = "Tic Tac Toe create by JDChristo.\nDate of creation : 19/03/2018";
        
        private const string playerOne = "X";
        private const string playerTwo = "O";
        private const string retryBtn = "Retry";

        private readonly Button[,] buttonGrid = new Button[3,3];

        private bool playerTurn = true;
        private int turnCount = 0;
        public string playerOneName
        {
            get => Player1.Text;
            set
            {
                Player1.Text = value;
            }
        }
        public string playerTwoName
        {
            get => Player2.Text;
            set
            {
                Player2.Text = value;
            }
        }
        enum GameState
        {
            GAME_START,
            GAMEOVER
        }

        public Form1(string p1, string p2)
        {
            InitializeComponent();
            buttonGrid = new Button[,] {
                {A1, A2, A3}, 
                {B1, B2, B3}, 
                {C1, C2, C3} 
            };
            playerOneName = string.IsNullOrEmpty(p1) ? "Player1" : p1;
            playerTwoName = string.IsNullOrEmpty(p2) ? "Player2" : p2;
        }
        private void ExitApp(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aboutText, "About");
        }
        private void ResetGame(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset the game?", "Warning", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                playerTurn = true;
                turnCount = 0;
                EnableAllButtons();
                Player1Score.Text = "0";
                Player2Score.Text = "0";
            }
        }
        private void RestartGame(object sender, EventArgs e)
        {
            playerTurn = true;
            turnCount = 0;
            EnableAllButtons();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            turnCount++;
            
            button.Text = playerTurn ? playerOne : playerTwo;
            button.Enabled = false;
            
            playerTurn = !playerTurn;
            CheckGameState();
        }

        private void CheckGameState()
        {
            bool flag = CheckHorizontal() || CheckVertical() || CheckDiagonal();

            string winner = playerTurn ? playerTwoName : playerOneName;


            if (flag)
            {
                DisbleAllButtons();
                IncreaseScore(playerTurn);
                DialogResult result = MessageBox.Show(winner + " Wins !!!", "GameOver", MessageBoxButtons.RetryCancel);
                if(result.ToString() == retryBtn)
                {
                    RestartGame(null,null);
                }
            }
            else if(turnCount == 9)
            {
                DialogResult result = MessageBox.Show("Game is Draw", "GameOver", MessageBoxButtons.RetryCancel); 
                if (result.ToString() == retryBtn)
                {
                    RestartGame(null, null);
                }
            }
        }

        private void IncreaseScore(bool turn)
        {
            if (turn) 
            {
                int score = Int32.Parse(Player2Score.Text);
                score++;
                Player2Score.Text = score.ToString();
            }
            else
            {
                int score = Int32.Parse(Player1Score.Text);
                score++;
                Player1Score.Text = score.ToString();
            }
        }

        private bool CheckButtonValue(Button a, Button b, Button c)
        {
            return (a.Text == b.Text) && (b.Text == c.Text);
        }
        private bool CheckVertical()
        {
            for (int i = 0; i < buttonGrid.GetLength(1); i++)
            {
                if (CheckButtonValue(buttonGrid[0, i],
                    buttonGrid[1, i],
                    buttonGrid[2, i]) && !buttonGrid[0, i].Enabled)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckHorizontal()
        {
            for(int i = 0; i < buttonGrid.GetLength(0); i++)
            {
                if(CheckButtonValue(buttonGrid[i,0], 
                    buttonGrid[i,1], 
                    buttonGrid[i,2]) && !buttonGrid[i,0].Enabled)
                {
                    return true;
                }
            }

            return false;
        }
        private bool CheckDiagonal()
        {
            if (CheckButtonValue(A1, B2, C3) && !B2.Enabled)
            {
                return true;
            }
            else if (CheckButtonValue(A3, B2, C1) && !B2.Enabled)
            {
                return true;
            }

            return false;
        }
        private void DisbleAllButtons()
        {
            foreach (Button b in buttonGrid)
            {
                b.Enabled = false;
            }
        }
        
        private void EnableAllButtons()
        {
            foreach (Button btn in buttonGrid)
            {
                btn.Enabled = true;
                btn.Text = string.Empty;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!btn.Enabled)
            {
                return;
            }

            btn.Text = playerTurn ? playerOne : playerTwo;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (!btn.Enabled)
            {
                return;
            }

            btn.Text = string.Empty;
        }

        private void ChangeP1Name(object sender, EventArgs e)
        {
            SetName stName = new SetName(this, true);
            stName.ShowDialog();
        }

        private void ChangeP2Name(object sender, EventArgs e)
        {
            SetName stName = new SetName(this, false);
            stName.ShowDialog();
        }

        private void OnGitButton(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JDChristo/TicTacToe");
        }

        private void OpenWebSite(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jdchristo.github.io/portfolio/");
        }
    }
}
