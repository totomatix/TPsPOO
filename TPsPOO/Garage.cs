using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Garage : Entreprise
    {
        private Dictionary<Car, Garagiste?> _Voitures = new Dictionary<Car, Garagiste?>();


        public Garage(string nom, long siret) : base(nom, siret)
        {

        }

        private Dictionary<Car, Garagiste?> Voitures { get => _Voitures; set => _Voitures = value; }

        public void DepotVoiture(Car car)
        {
            Voitures.Add(car, null);
        }

        public void RetraitVoiture(Car car)
        {
            Voitures.Remove(car);
        }

        public void AssocierGaragisteVoiture(Garagiste garagiste, Car car)
        {
            if (Voitures.ContainsKey(car)) // si la voitures est déjà dans le garage
            {
                Voitures[car] = garagiste; // on associe le garagiste à la voiture
            }
        }
    }
}
