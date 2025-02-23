using TPObjet;

Person john = new Person("Doe", "John", 10);
Person john2 = new Person("Doe", "John2", 20);


Car audiTT = new Car("AV48CE", "TT", "Audi", 80000, new DateTime(2012, 2, 21), 211, john);
Car x5 = new Car("FH55EE", "X5", "BMW", 80000, new DateTime(2009, 11, 10), 235, john);

Console.WriteLine(@$"
    {audiTT.Print()}
    {x5.Print()}
    "
    );

List<string> Registrations = Car.GetRegistrations().ToList();
for(int i = 0; i < Registrations.Count(); i++)
{
    Console.WriteLine(Registrations[i]);
}

audiTT.Registration = "FH55EE";

Console.WriteLine("Liste des nouvelle plaques :");
Registrations = Car.GetRegistrations().ToList();
for(int i = 0; i < Registrations.Count(); i++)
{
    Console.WriteLine(Registrations[i]);
}

Console.WriteLine($"Nombre d'instance personne : {Person.CompteurInstance}");
Console.WriteLine($"Age moyen des personnes : {Person.GetAverageAgeStatic()}");