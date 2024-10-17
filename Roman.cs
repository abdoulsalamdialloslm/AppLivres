using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, string genre, int nombredepages)
            : base(titre, auteur, nombredepages)
        {
            Genre = genre;
        }


        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
