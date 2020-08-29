using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ChessBoard
{
    class Program
    {

        static List<Carte> Dex = new List<Carte>(); // création du deck
        static List<Carte> DexShuffled = Dex; // création du deck melangé
        static List<Carte> laMain = new List<Carte>(); // création de la main


        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le deck");
            Menu(); // Affichage du menu 
        }   

        static void Menu()  // Menu 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Que voulez-vous faire ? \n");
            Console.WriteLine("1. Générer le deck");
            Console.WriteLine("2. Afficher le deck");
            Console.WriteLine("3. Piocher le chien");
            Console.WriteLine("4. Afficher le chien \n");
            Console.WriteLine("5. Melanger le deck");

            switch (Console.ReadLine()) // Action du choix de l'user 
            {
                case ("1"):
                    {
                        GenererDeck();
                        break;
                    }
                case ("2"):
                    {
                        AfficherDeck();
                        break;
                    }
                case ("3"):
                    {
                        PiocherChien();
                        break;
                    }
                case ("4"):
                    {
                        break;
                    }
                case ("5"):
                    {
                        MelangerDeck();
                        break;
                    }


            }
        }

        static void GenererDeck()
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

            Console.WriteLine("Les chiffres ont bien été generés le deck fait " + Dex.Count + " cartes.");


            IEnumerable<int> atouts = Enumerable.Range(1, 21);
            List<Atout> Deck = new List<Atout>();
            foreach (int num in atouts)
            {
                Dex.Add(new Atout(num));
            }
            Console.WriteLine("Les atouts ont bien été generés le deck fait " + Dex.Count + " cartes.");


            Excuse excuse = new Excuse();
            Dex.Add(excuse);
            Console.WriteLine("L'excuse a bien été générée le deck fait" + Dex.Count + " cartes.");

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

            noms[42] = "As de trèfle";
            noms[43] = "Deux de trèfle";
            noms[44] = "Trois de trèfle";
            noms[45] = "Quatre de trèfle";
            noms[46] = "Cinq de trèfle";
            noms[47] = "Six de trèfle";
            noms[48] = "Sept de trèfle";
            noms[49] = "Huit de trèfle";
            noms[50] = "Neuf de trèfle";
            noms[51] = "Dix de trèfle";
            noms[52] = "Valet de trèfle";
            noms[53] = "Cavalier de trèfle";
            noms[54] = "Dame de trèfle";
            noms[55] = "Roi de trèfle";

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

            Console.WriteLine("Les noms ont bien été attribués. Retour au MENU ==> \n");
            Menu();
        } // Genere toutes les cartes et attribue les noms (methodes detailles dans "draft.cs")

        static void AfficherDeck()
        {
            for (int i = 0; i < Dex.Count; i++)
            {
                Console.WriteLine(Dex[i].nom);
            }
            Console.WriteLine("Retour au MENU ==> \n");
            Menu();

        } // Affiche une liste des noms de toutes les cartes

        static void MelangerDeck()
        {
            
            var random = new Random();
            DexShuffled.Sort((x, y) => random.Next(543, 987654));
            // DexShuffled.Sort((x, y) => random.Next(-1, 2)); // marche aussi mais résultats tout aussi insatisfaisants

            // Affichage du deck mélangé : 
            for (int i = 0; i < DexShuffled.Count; i++)
            {
                Console.WriteLine(DexShuffled[i].nom);
            }
            Console.WriteLine("Retour au MENU ==> \n");

            Menu();

        }

        static void PiocherChien()
        {
            Console.WriteLine("piochage du chien");
            //Random aleatoire = new Random();
            //int chien1 = aleatoire.Next(79); //Génère un entier compris entre 0 et 78


            Console.WriteLine("il y a " + Dex.Count());

             List<Carte> chien = Dex;

            


            for (int i = 0; i < chien.Count; i++)
            {
                Console.WriteLine(chien[i].nom);
            }
            Console.WriteLine("Retour au MENU ==> \n");
            Menu();

        } // Affiche une liste des noms de toutes les cartes


    }








    
}
