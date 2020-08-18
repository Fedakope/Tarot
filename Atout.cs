using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    public class Atout : Carte
    {
        public int force;

        public Atout(int force)
        {
            this.force = force;
        }

        public string forceAtout(Atout atout)
        {
            return "ma force est de :" + atout.force;
        }
    }
}
