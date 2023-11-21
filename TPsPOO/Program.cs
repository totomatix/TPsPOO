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
JohnDoe.AddCar(C1);
JohnDoe.AddCar(C2);

// affichage de john doe
JohnDoe.Print();

// affichage du nombre de personnes créées
Console.WriteLine($"Il y'a actuellement {Personne.GetNbInstances()} instances de personne.");

// Création d'une autre personne
Personne P2 = new Personne("Larcher", "Gérard", 151);
P2.Print();

// affichage du nombre de personnes créées
Console.WriteLine($"Il y'a actuellement {Personne.GetNbInstances()} instances de personne.");

Console.WriteLine($"La moyenne d'âge des personnes est égale à {Personne.AgeMoyen()}");

Entreprise E1 = new Entreprise("Ent1", 123456);
Garage G1 = new Garage("Gar1", 654321);

E1.AfficherIdentite();
G1.AfficherIdentite();

G1.DepotVoiture(C1);
G1.DepotVoiture(C2);
Garagiste Garagiste1 = new Garagiste();
G1.AssocierGaragisteVoiture(Garagiste1, C1);
G1.RetraitVoiture(C2);
G1.AfficherIdentite();
