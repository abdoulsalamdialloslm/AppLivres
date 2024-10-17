using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    
        {
            public int Annee { get; set; }
            public int Numero { get; set; }

            public Revue(string titre, string auteur, int nombrepages, int annee, int numero)
                : base(titre, auteur, nombrepages)
            {
                Annee = annee;
                Numero = numero;
            }

            public override void AfficherDetails()
            {
                base.AfficherDetails();
                Console.WriteLine($"Annee: {Annee}, Numéro: {Numero}");
            }
        }

    
}
