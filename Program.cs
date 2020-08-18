using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ChessBoard
{
    class Program
    {

        static List<Carte> Dex = new List<Carte>(); // création de la liste

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le deck");
            Menu(); // Affichage du menu 
        }   

        static void Menu()  // Menu 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Que voulez-vous faire ? ");
            Console.WriteLine("");
            Console.WriteLine("1. Générer les cartes (chiffres)");
            Console.WriteLine("2. Générer les cartes (atouts)");
            Console.WriteLine("3. Générer la carte (excuse)");
            Console.WriteLine("4. Piocher une main");
            Console.WriteLine("5. Afficher la main");
            
            Console.WriteLine("");

            switch (Console.ReadLine()) // Action du choix de l'user 
            {
                case ("1"):
                    {
                        GenererCartes();
                        break;
                    }
                case ("2"):
                    {
                        GenererAtouts();
                        break;
                    }
                case ("3"):
                     {
                        GenererExcuse();
                        break;
                     }
                case ("4"):
                    {
                        PiocherMain();
                        break;
                    }
                case ("5"):
                    {
                        AfficherMain();
                        break;
                    }

            }
        }

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

            Console.WriteLine("Le jeu a bien été généré il comporte " + Dex.Count + " cartes chiffres. Retour au menu ==>");
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
            Console.WriteLine("Le jeu a bien été généré il comporte " + Dex.Count + " cartes atouts. Retour au menu ==>");
            Console.WriteLine(" ");
            Menu();
        }

        static void GenererExcuse()
        {
            Excuse excuse = new Excuse();
            Dex.Add(excuse);
            Console.WriteLine(Dex.Count());
            Menu();
        }

        static void PiocherMain()
        {
            Console.WriteLine("piochage de main");

        }
        static void AfficherMain()
        {
            Console.WriteLine(Dex.Count());
            Dex.ToArray();
            foreach (Carte item in Dex)
            {
                item.AfficherNom(item);
                
            }

        }
    }
}
