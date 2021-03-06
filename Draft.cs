static void GenererCartes()
{
    {
        string[] Color = { "carreaux", "coeur", "pique", "trefle" };
        int[] Strenght = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };  //Range? 

        foreach (var couleur in Color)
        {
            foreach (var force in Strenght)
            {
                Dex.Add(new Chiffres(couleur, force));
            }
        }

        Console.WriteLine("Le jeu a bien �t� g�n�r� il comporte " + Dex.Count + " cartes. Retour au menu ==>");
        Console.WriteLine(" ");

        Menu();
    }
}

static void GenererAtouts()
{
    IEnumerable<int> atouts = Enumerable.Range(1, 21);
    List<Atout> Deck = new List<Atout>();
    foreach (int num in atouts)
    {
        Dex.Add(new Atout(num));
    }
    Console.WriteLine("Le jeu a bien �t� g�n�r� il comporte " + Dex.Count + " cartes. Retour au menu ==>");
    Console.WriteLine(" ");
    Menu();
}

static void GenererExcuse()
{
    Excuse excuse = new Excuse();
    Dex.Add(excuse);
    Console.WriteLine("Le jeu a bien �t� g�n�r� il comporte maintenant " + Dex.Count + " cartes. Retour au menu ==>");
    Menu();
}

static void AttribuerNom()
{
    #region "Tableau contenant tous les noms propres des cartes"
    string[] noms = new string[78];
    noms[0] = "As de carreau";
    noms[1] = "Deux de carreau";
    noms[2] = "Trois de carreau";
    noms[3] = "Quatre de carreau";
    noms[4] = "Cinq de carreau";
    noms[5] = "Six de carreau";
    noms[6] = "Sept de carreau";
    noms[7] = "Huit de carreau";
    noms[8] = "Neuf de carreau";
    noms[9] = "Dix de carreau";
    noms[10] = "Valet de carreau";
    noms[11] = "Cavalier de carreau";
    noms[12] = "Dame de carreau";
    noms[13] = "Roi de carreau";

    noms[14] = "As de coeur";
    noms[15] = "Deux de coeur";
    noms[16] = "Trois de coeur";
    noms[17] = "Quatre de coeur";
    noms[18] = "Cinq de coeur";
    noms[19] = "Six de coeur";
    noms[20] = "Sept de coeur";
    noms[21] = "Huit de coeur";
    noms[22] = "Neuf de coeur";
    noms[23] = "Dix de coeur";
    noms[24] = "Valet de coeur";
    noms[25] = "Cavalier de coeur";
    noms[26] = "Dame de coeur";
    noms[27] = "Roi de coeur";

    noms[28] = "As de pique";
    noms[29] = "Deux de pique";
    noms[30] = "Trois de pique";
    noms[31] = "Quatre de pique";
    noms[32] = "Cinq de pique";
    noms[33] = "Six de pique";
    noms[34] = "Sept de pique";
    noms[35] = "Huit de pique";
    noms[36] = "Neuf de pique";
    noms[37] = "Dix de pique";
    noms[38] = "Valet de pique";
    noms[39] = "Cavalier de pique";
    noms[40] = "Dame de pique";
    noms[41] = "Roi de pique";

    noms[42] = "As de tr�fle";
    noms[43] = "Deux de tr�fle";
    noms[44] = "Trois de tr�fle";
    noms[45] = "Quatre de tr�fle";
    noms[46] = "Cinq de tr�fle";
    noms[47] = "Six de tr�fle";
    noms[48] = "Sept de tr�fle";
    noms[49] = "Huit de tr�fle";
    noms[50] = "Neuf de tr�fle";
    noms[51] = "Dix de tr�fle";
    noms[52] = "Valet de tr�fle";
    noms[53] = "Cavalier de tr�fle";
    noms[54] = "Dame de tr�fle";
    noms[55] = "Roi de tr�fle";

    noms[56] = "Atout : 1 - Le Petit";
    noms[57] = "Atout : 2";
    noms[58] = "Atout : 3";
    noms[59] = "Atout : 4";
    noms[60] = "Atout : 5";
    noms[61] = "Atout : 6";
    noms[62] = "Atout : 7";
    noms[63] = "Atout : 8";
    noms[64] = "Atout : 9";
    noms[65] = "Atout : 10";
    noms[66] = "Atout : 11";
    noms[67] = "Atout : 12";
    noms[68] = "Atout : 13";
    noms[69] = "Atout : 14";
    noms[70] = "Atout : 15";
    noms[71] = "Atout : 16";
    noms[72] = "Atout : 17";
    noms[73] = "Atout : 18";
    noms[74] = "Atout : 19";
    noms[75] = "Atout : 20";
    noms[76] = "Atout : 21";

    noms[77] = "Excuse";

    #endregion

    for (int i = 0; i < Dex.Count(); i++)
    {
        Dex[i].nom = noms[i];
    }

    Menu();

}

