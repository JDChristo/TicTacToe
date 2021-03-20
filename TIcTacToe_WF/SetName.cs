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
    public partial class SetName : Form
    {
        private Form1 game;
        private bool playerOne;
        public SetName(Form1 g, bool flag = true)
        {
            InitializeComponent();
            game = g;
            playerOne = flag;
        }

        private void OnEnterBtn(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameBox.Text))
            {
                return;
            }

            if (playerOne)
            {
                game.playerOneName = NameBox.Text;
            }
            else
            {
                game.playerTwoName = NameBox.Text;
            }
            Close();
        }
    }
}
