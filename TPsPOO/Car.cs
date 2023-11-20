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
        private string _Registration;
        private string _Model;
        private string _Brand;
        private int _KM;
        private DateTime _DateDeMiseEnService;
        private int _Power;
        private Personne? _Owner;
        private static List<string> ListImmatriculations = new List<string>();

        public string Registration { 
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
        public string Model { get => _Model; set => _Model = value; }
        public string Brand { get => _Brand; set => _Brand = value; }
        public int KM { get => _KM; set => _KM = value; }
        public DateTime DateDeMiseEnService { get => _DateDeMiseEnService; set => _DateDeMiseEnService = value; }
        public int Power { get => _Power; set => _Power = value; }
        public Personne? Owner { get => _Owner; private set => _Owner = value; }

        public void AddOwner(Personne personne)
        {
            Owner = personne;
        }

        public void RemoveOwner()
        {
            Owner = null;
        }

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
