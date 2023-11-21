using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Entreprise
    {
        // attributs
        private string _Nom = string.Empty;
        private long _Siret;

        public Entreprise(string nom, long siret)
        {
            Nom = nom;
            Siret = siret;
        }

        public string Nom { get => _Nom.ToUpper(); set => _Nom = value; } 
        public long Siret { get => _Siret; set => _Siret = value; }

        public void AfficherIdentite()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Siret : {Siret}");
        }
    }
}
