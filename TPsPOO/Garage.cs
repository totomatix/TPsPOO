using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Garage : Entreprise
    {

        #region Constructeurs
        /// <summary>
        /// Constructeur permettant de créer un garage en renseignant son nom d'entreprise et son numéro SIRET. Instantie également le dictionnaire contenant la liste des voitures à réparer ainsi que les possibles garagistes assignés à chaque voiture
        /// </summary>
        /// <param name="nom">Nom de l'entreprise</param>
        /// <param name="siret">Numéro SIRET</param>
        public Garage(string nom, long siret) : base(nom, siret)
        {
            Vehicules = new Dictionary<Vehicule, Garagiste?>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// DIctionnaire contenant les véhicules à réparer ainsi que le possible garagiste assigné à chacune d'entre elle
        /// </summary>
        private Dictionary<Vehicule, Garagiste?> Vehicules { get; set; }
        #endregion

        #region Méthodes
        /// <summary>
        /// Permet à un client de déposer son vehicule au garage
        /// </summary>
        /// <param name="vehicule">Véhicule à réparer</param>
        public void DepotVehicule(Vehicule vehicule)
        {
            Vehicules.Add(vehicule, null);
        }

        /// <summary>
        /// Permet à un client de venir récupérer son véhicule
        /// </summary>
        /// <param name="vehicule">Véhicule à retirer</param>
        public void RetraitVehicule(Vehicule vehicule)
        {
            Vehicules.Remove(vehicule);
        }

        /// <summary>
        /// Méthode permettant d'ssocier un garagiste à une voiture
        /// </summary>
        /// <param name="garagiste">Garagiste</param>
        /// <param name="vehicule">Voiture</param>
        public void AssocierGaragisteVehicule(Garagiste garagiste, Vehicule vehicule)
        {
            if (Vehicules.ContainsKey(vehicule)) // si la voitures est déjà dans le garage
            {
                Vehicules[vehicule] = garagiste; // on associe le garagiste à la voiture
            }
        }

        /// <summary>
        /// Méthode permettant d'afficher l'identité du garage
        /// </summary>
        public override void AfficherIdentite()
        {
            Console.WriteLine("Garage automobile : ");
            Console.WriteLine($"\tNom : {Nom}");
            Console.WriteLine($"\tSiret : {Siret}");
        }

        public void AfficherGaragisteAssigneVehicule(Vehicule vehicule)
        {
            if (Vehicules.ContainsKey(vehicule))
            {
                if (Vehicules[vehicule] != null)
                {
                    Console.WriteLine($"Le garagiste {Vehicules[vehicule].Name} {Vehicules[vehicule].FirstName} est en charge de la réparation de ce véhicule.");
                }
                else
                {
                    Console.WriteLine("Il n'y a actuellement aucun garagiste assigné à la réparation de ce véhicule.");
                }
            }
            else
            {
                Console.WriteLine("Ce véhicule n'est actuellement pas en réparation dans ce garage.");
            }
        }

        public override string? ToString()
        {
            return base.ToString() 
                 + "\nType d'entrerprise : Garage automobile";
        }


        #endregion
    }
}
