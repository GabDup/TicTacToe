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
        //public Boolean possibilitéesGagnant(int ligne, int colonne)
        //{
        //    do
        //    {
                
        //    } while ();
            
        //}
        public Boolean gagnant()
        {
            for (int ligne = 0; ligne <= tableauGagnant.GetUpperBound(0); ligne++)
            {
                for (int colonne = 0; colonne < tableauGagnant.GetUpperBound(1); colonne++)
                {
                    if (joueur == tableauGagnant[0, 0] + tableauGagnant[0, 1] + tableauGagnant[0, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[0, 0] + tableauGagnant[1, 0] + tableauGagnant[2, 0])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[0, 1] + tableauGagnant[1, 1] + tableauGagnant[2, 1])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[0, 2] + tableauGagnant[1, 2] + tableauGagnant[2, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[1, 0] + tableauGagnant[1, 1] + tableauGagnant[1, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[2, 0] + tableauGagnant[2, 1] + tableauGagnant[2, 2])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[0,0] + tableauGagnant[1,1] + tableauGagnant[2,2])
                    {
                        return true;
                    }
                    if (joueur == tableauGagnant[0,2] + tableauGagnant[1,1] + tableauGagnant[2,0])
                    {
                        return true;
                    }
                }
            }
        return false;
        }
    }
}
