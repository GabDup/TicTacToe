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
        classTicTacToe tourJoueur = new classTicTacToe("x");
        public TicTacToe()
        {
            InitializeComponent();
        }
        public void tour(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numeroButton = int.Parse(button.Name.Substring(3)); 
            button.Text = tourJoueur.joueur;
            tourJoueur.changerTour();
            button.Enabled = false;
        }
        private void TicTacToe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            
        }
    }
}
