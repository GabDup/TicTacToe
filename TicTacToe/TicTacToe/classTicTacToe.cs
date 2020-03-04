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
        public string[,] tableauJouer = new string [3,3];

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
            tableauJouer[ligne, colonne] = joueur;
        }
        public Boolean trouverJoueurGagnant()
        {
            for (int ligne = 0; ligne <= tableauJouer.GetUpperBound(0); ligne++)
            {
                for (int colonne = 0; colonne < tableauJouer.GetUpperBound(1); colonne++)
                {
                    if (joueur == tableauJouer[0, 0] && joueur == tableauJouer[0, 1] && joueur == tableauJouer[0, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[0, 0] && joueur == tableauJouer[1, 0] && joueur == tableauJouer[2, 0])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[0, 1] && joueur == tableauJouer[1, 1] && joueur == tableauJouer[2, 1])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[0, 2] && joueur == tableauJouer[1, 2] && joueur == tableauJouer[2, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[1, 0] && joueur == tableauJouer[1, 1] && joueur == tableauJouer[1, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[2, 0] && joueur == tableauJouer[2, 1] && joueur == tableauJouer[2, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[0,0] && joueur == tableauJouer[1,1] && joueur == tableauJouer[2,2])
                    {
                        return true;
                    }
                    if (joueur == tableauJouer[0,2] && joueur == tableauJouer[1,1] && joueur == tableauJouer[2,0])
                    {
                        return true;
                    }
                }
            }
        return false;
        }
    }
}
