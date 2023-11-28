using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Personne
    {
        #region Attributs
        private string _Name;
        private string _FirstName;
        private int _Age;
        private List<Vehicule> _ListeCar = new List<Vehicule>();
        private static int _CompteurInstances;
        private static List<int> ListAges = new List<int>();
        #endregion

        #region Constructeurs
        public Personne()
        {
            _CompteurInstances++;
        }
        public Personne(string name, string firstName, int age)
        {
            Name = name;
            FirstName = firstName;
            Age = age;
            _CompteurInstances++;
        }
        // destructeur
        ~Personne()
        {
            _CompteurInstances--;
        }
        #endregion

        #region Properties
        public string Name { get => _Name; set => _Name = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public int Age
        {
            get => _Age; set
            {
                _Age = value;
                ListAges.Add(value); // ajout de l'âge à la liste d'âges
            }
        }
        #endregion

        #region Méthodes
        public void Print()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Firstname : {FirstName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine("Voitures :");
            foreach (Vehicule car in _ListeCar)
            {
                car.Print();
            }

        }

        public void AddCar(Vehicule car)
        {
            _ListeCar.Add(car);
        }

        public void RemoveCar(Vehicule car)
        {
            _ListeCar.Remove(car);
        }

        public static int GetNbInstances()
        {
            return _CompteurInstances;
        }

        public static double AgeMoyen()
        {
            return Convert.ToDouble(ListAges.Sum()) / ListAges.Count;
        }

        public override string? ToString()
        {
            return $"Nom : {Name}\n" +
                $"Prenom : {FirstName}";
        }

        public override bool Equals(object? obj)
        {
            // on appelle le equals de object car on ne souhaite pas que deux instances différentes de personnes puissent être égales
            return base.Equals(obj);
        }



        #endregion
    }
}
