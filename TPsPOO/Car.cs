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
        private string Registration;
        private string Model;
        private string Brand;
        private int KM;
        private DateTime DateDeMiseEnService;
        private int Power;
        private Personne? Owner;

        public string GetRegistration()
        {
            return Registration;
        }

        public void SetRegistration(string registration)
        {
            Registration = registration;
        }

        public string GetModel()
        {
            return Model;
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public string GetBrand()
        {
            return Brand;
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public int GetKM()
        {
            return KM;
        }

        public void SetKM(int km)
        {
            KM = km;
        }

        public DateTime GetDateDeMiseEnService()
        {
            return DateDeMiseEnService;
        }

        public void SetDateDeMiseEnService(DateTime date)
        {
            DateDeMiseEnService = date;
        }

        public int GetPower()
        {
            return Power;
        }

        public void SetPower(int power)
        {
            Power = power;
        }

        public Personne GetOwner()
        {
            return Owner;
        }

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
