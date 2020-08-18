using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    
    public class Chiffres : Carte
    {
        
        public string couleur;
        public int force;

        public Chiffres(string couleur, int force)
        {
            this.couleur = couleur;
            this.force = force;
        }
            
    }
}
