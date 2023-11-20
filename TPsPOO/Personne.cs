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
        private string Name;
        private string FirstName;
        private int Age;
        private List<Car> ListeCar = new List<Car>();

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string firstname)
        {
            FirstName = firstname;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

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

        public void AddCar(Car car)
        {
            ListeCar.Add(car);
        }

        public void RemoveCar(Car car)
        {
            ListeCar.Remove(car);
        }
    }
}
