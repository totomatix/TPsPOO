using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Entreprise
    {

        #region Attributs
        private string _Nom = string.Empty;
        private long _Siret;
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur permettant d'instantier une entreprise en renseignat son nom et son numéro SIRET
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="siret"></param>
        public Entreprise(string nom, long siret)
        {
            Nom = nom;
            Siret = siret;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Nom de l'entreprise
        /// </summary>
        public string Nom { get => _Nom.ToUpper(); set => _Nom = value; }
        /// <summary>
        /// Numéro SIRET de l'entreprise
        /// </summary>
        public long Siret { get => _Siret; set => _Siret = value; }
        #endregion

        #region Méthodes
        /// <summary>
        /// Méthode permettant d'afficher l'identité d'une entreprise
        /// </summary>
        public virtual void AfficherIdentite()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Siret : {Siret}");
        }

        public override bool Equals(object? obj)
        {
            return obj is Entreprise entreprise &&
                   Siret == entreprise.Siret;
        }

        public override string? ToString()
        {
            return $"Nom : {Nom}\n" +
                $"Siret : {Siret}";
        }


        #endregion

    }
}
