using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPsPOO
{
    public class Personne
    {
        // attributs
        private string _Name;
        private string _FirstName;
        private int _Age;
        private List<Car> _ListeCar = new List<Car>();
        private static int _CompteurInstances;
        private static List<int> ListAges = new List<int>();

        // constructeurs
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

        public string Name { get => _Name; set => _Name = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public int Age { get => _Age; set { _Age = value;
                ListAges.Add(value); // ajout de l'âge à la liste d'âges
            } }

        public void Print()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Firstname : {FirstName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine("Voitures :");
            foreach (Car car in _ListeCar)
            {
                car.Print();
            }

        }

        public void AddCar(Car car)
        {
            _ListeCar.Add(car);
        }

        public void RemoveCar(Car car)
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
    }
}
