// Création de JohnDOe
using TPsPOO;

Personne JohnDoe = new Personne();
JohnDoe.Name = "Doe";
JohnDoe.FirstName = "John";
JohnDoe.Age = 20;

// création des deux voitures
Car C1 = new Car();
C1.Brand = "Audi";
C1.Model = "TT";
C1.Registration = "AV48CE";
C1.DateDeMiseEnService = new DateTime(2012, 02, 21);
C1.Power = 211;
C1.KM = 20345;

Car C2 = new Car();
C2.Brand = "BMW";
C2.Model = "X5";
C2.Registration = "FH55EE";
C2.DateDeMiseEnService = new DateTime(2009, 11, 10);
C2.Power = 235;
C2.KM = 34567;

// ajout des deux voitures à la liste de voitures de john doe
JohnDoe.ListeCar.Add(C1);
JohnDoe.ListeCar.Add(C2);

// affichage de john doe
JohnDoe.Print();