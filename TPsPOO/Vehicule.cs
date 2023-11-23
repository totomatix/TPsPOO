using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TPsPOO
{
    public class Vehicule 
    {
        #region Attributs
        private string _Registration;
        private string _Model;
        private string _Brand;
        private int _KM;
        private DateTime _DateDeMiseEnService;
        private int _Power;
        private Personne? _Owner;
        private static List<string> ListImmatriculations = new List<string>();
        private uint _Dommages;
        #endregion

        #region Properties
        /// <summary>
        /// Plaque d'immatriculation de le véhicule
        /// Quand cette properties est mise à jour, la plque d'immatriculation est ajoutée à la liste de plaque d'immatriculations gérée par la classe Car
        /// </summary>
        public string Registration
        {
            get => _Registration;
            set
            {
                _Registration = value;
                if (!ListImmatriculations.Contains(_Registration))
                {
                    ListImmatriculations.Add(_Registration);
                }
            }
        }
        /// <summary>
        /// Modèle de le véhicule
        /// </summary>
        public string Model { get => _Model; set => _Model = value; }
        /// <summary>
        /// Marque de le véhicule
        /// </summary>
        public string Brand { get => _Brand; set => _Brand = value; }
        /// <summary>
        /// Kilométrage de le véhicule
        /// </summary>
        public int KM { get => _KM; set => _KM = value; }
        /// <summary>
        /// Date de mise en service de le véhicule
        /// </summary>
        public DateTime DateDeMiseEnService { get => _DateDeMiseEnService; set => _DateDeMiseEnService = value; }
        /// <summary>
        /// Puissance de le véhicule
        /// </summary>
        public int Power { get => _Power; set => _Power = value; }
        /// <summary>
        /// Propriétaire de le véhicule, peut être null c'est à dire que le véhicule peut ne pas avoir de propriétaire
        /// La modification du propriétaire doit se faire par la méthode AddOwner()
        /// </summary>
        public Personne? Owner { get => _Owner; private set => _Owner = value; }

        /// <summary>
        /// Dommages subis par le véhicule en %. (entre 0 et 100)
        /// </summary>
        public uint Dommages
        {
            get => _Dommages; set
            {
                if (value > 100)
                {
                    _Dommages = 100;
                }
                else
                {
                    _Dommages = value;
                }
            }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Méthode permettant d'ajouter un propriétaire à le véhicule
        /// </summary>
        /// <param name="personne"></param>
        public void AddOwner(Personne personne)
        {
            Owner = personne;
        }

        /// <summary>
        /// Méthode permettant de supprimer le propriétaire de le véhicule
        /// </summary>
        public void RemoveOwner()
        {
            Owner = null;
        }

        /// <summary>
        /// Méthode permettant d'afficher les informations de le véhicule
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Registration : {Registration}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"KM : {KM}");
            Console.WriteLine($"DateDeMiseEnService : {DateDeMiseEnService}");
            Console.WriteLine($"Power : {Power}");
        } 

        /// <summary>
        /// Retourne le temps nécéssaire estimé pour la réparation du véhicule, dépend du talent du garagiste.
        /// </summary>
        /// <param name="skillGaragiste">Talent du garagiste</param>
        /// <returns></returns>
        public virtual double TempsReperationEstime(uint skillGaragiste)
        {
            return Dommages * (2 - skillGaragiste / 100);
        }
        #endregion


    }
}
