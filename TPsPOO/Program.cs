// Création de JohnDOe
using TPsPOO;

Personne JohnDoe = new Personne();
JohnDoe.SetName ("Doe");
JohnDoe.SetFirstName ("John");
JohnDoe.SetAge (20);

// création des deux voitures
Car C1 = new Car();
C1.SetBrand("Audi");
C1.SetModel("TT");
C1.SetRegistration("AV48CE");
C1.SetDateDeMiseEnService(new DateTime(2012, 02, 21));
C1.SetPower(211);
C1.SetKM(20345);

Car C2 = new Car();
C2.SetBrand("BMW");
C2.SetModel("X5");
C2.SetRegistration("FH55EE");
C2.SetDateDeMiseEnService(new DateTime(2009, 11, 10));
C2.SetPower(235);
C2.SetKM(34567);

// ajout des deux voitures à la liste de voitures de john doe
JohnDoe.AddCar(C1);
JohnDoe.AddCar(C2);

// affichage de john doe
JohnDoe.Print();