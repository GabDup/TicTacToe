using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        public string joueur = "x";
        public TicTacToe()
        {
            InitializeComponent();
        }
        public void tour(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numeroButton = int.Parse(button.Name.Substring(3));
            if (joueur == "x")
            {
                button.Text = joueur;
                button.Enabled = false;
                joueur = "o";
            }
            else
            {
                button.Text = joueur;
                joueur = "x";
                button.Enabled = false;
            }
        }
        private void TicTacToe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
