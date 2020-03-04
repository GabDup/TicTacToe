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
            int ligne = int.Parse(button.Name.Substring(3,1));
            int colonne = int.Parse(button.Name.Substring(4, 1));
            button.Text = tourJoueur.joueur;
            tourJoueur.jouer(ligne, colonne);
            button.Enabled = false;
            if (tourJoueur.trouverJoueurGagnant() == true)
            {
                MessageBox.Show(tourJoueur.joueur + " gagne");
                
            }
            tourJoueur.changerTour();
        }
        private void TicTacToe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            grbtictactoe4x4.Visible = false;
            grbTicTacToe3x3.Visible = true;
        }

        private void Btn4x4_Click(object sender, EventArgs e)
        {
            if (grbtictactoe4x4.Visible == false)
            {
                grbtictactoe4x4.Visible = true;
                grbTicTacToe3x3.Visible = false;
            }
        }

        private void Btn3x3_Click(object sender, EventArgs e)
        {
            if (grbTicTacToe3x3.Visible == false)
            {
                grbTicTacToe3x3.Visible = true;
                grbtictactoe4x4.Visible = false;
            }
        }

        private void Grbtictactoe4x4_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
