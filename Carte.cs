using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{

    
    public abstract class Carte
    {
        public void  AfficherNom(Carte carte)
        {
            if (carte is Atout)
            {
                Console.WriteLine("on a un atout ! c'est le numéro : ") ;
                Console.WriteLine();
                
            }

            if (carte is Chiffres)
            {
                //return "on a un chiffre ! c'est le numéro : ";

            }

            if (carte is Excuse)
            {
               // return "Jmexcuse";

            }
            else
            {
               // return "Aucun type de carte detécté";
            }
        }
    }
}
