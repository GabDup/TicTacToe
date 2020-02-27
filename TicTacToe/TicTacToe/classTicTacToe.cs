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
        public string[,] tableauGagnant = new string [3,3];

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
        public void jouer(int ligne, int colonne)
        {
            tableauGagnant[ligne, colonne] = joueur;
        }
        public Boolean gagnant()
        {

            //    for (int ligne = 0; ligne <= tableauGagnant.GetUpperBound(0); ligne++)
            //    {
            //        for (int colonne = 0; colonne < tableauGagnant.GetUpperBound(1); colonne++)
            //        {
            //            if ()
            //            {

            //            }
            //        }
            //    }
            return false;
        }
    }
}
