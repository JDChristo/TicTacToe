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
    public partial class StartForm : Form
    {
        private string p1name;
        private string p2name;

        public StartForm()
        {
            InitializeComponent();
        }

        private void OnClickPlayBtn(object sender, EventArgs e)
        {
            p1name = p1_Name.Text;
            p2name = p2_Name.Text;
            this.Hide();

            Form1 game = new Form1(p1name, p2name);
            game.ShowDialog();

            this.Show();
        }

        private void OnExitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
