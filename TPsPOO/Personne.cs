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
        public string Name;
        public string FirstName;
        public int Age;
        public List<Car> ListeCar = new List<Car>();

        public void Print()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Firstname : {FirstName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine("Voitures :");
            foreach (Car car in ListeCar)
            {
                car.Print();
            }

        }
    }
}
