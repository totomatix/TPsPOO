using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TPsPOO
{
    public class Car
    {
        // attributs
        public string Registration;
        public string Model;
        public string Brand;
        public int KM;
        public DateTime DateDeMiseEnService;
        public int Power;
        public Personne Owner;

        // méthodes
        public void Print()
        {
            Console.WriteLine($"Registration : {Registration}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"KM : {KM}");
            Console.WriteLine($"DateDeMiseEnService : {DateDeMiseEnService}");
            Console.WriteLine($"Power : {Power}");
        }
    }
}
