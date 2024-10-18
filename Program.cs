using AppConsoleLivres;
using System;
using System.Collections.Generic;
internal class Program
{
        private static void Main(string[] args)
        {
            List<Livre> Livrelist = new List<Livre>();
            // Création d'une liste générique de type Livre

            // Création de quelques objets de type Revue et Roman
            Revue revue1 = new Revue("Science Magazine", "Auteur A", 12345, 55, 101);
            Revue revue2 = new Revue("Tech Today", "Auteur B", 67890, 45, 202);
            Revue revue3 = new Revue("Cuisine du Monde", "Auteur C", 11223, 878, 303);

            Roman roman1 = new Roman("Le Mystère de l'Ombre", "Auteur D", "drame", 350);
            Roman roman2 = new Roman("Les Voyageurs", "Auteur E", "drole", 420);
            Roman roman3 = new Roman("Sous le ciel de Paris", "Auteur F", "peureux",  300);

        // Ajout des objets à la liste de type Livre
            Livrelist.Add(revue1);
            Livrelist.Add(revue2);
            Livrelist.Add(revue3);
            Livrelist.Add(roman1);
            Livrelist.Add(roman2);
            Livrelist.Add(roman3);

        foreach (var livre in Livrelist) {
            livre.AfficherDetails ();
            Console.WriteLine ();
        }


            // Pause pour voir la sortie dans la console
            Console.ReadLine();
        }
    
}