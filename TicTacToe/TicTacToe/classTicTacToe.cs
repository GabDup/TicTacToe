using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    public class classTicTacToe
    {
        public string joueur;
        public classTicTacToe(string joueur)
        {
            this.joueur = joueur;
        }
        public void changerTour()
        {
            
            if (joueur == "x")
            {
                joueur = "o";
            }
            else
            {
                joueur = "x";
            }
        }
        //public string[] tableauGagnant;

    }
}
