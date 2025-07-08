using TPObjet;

Client client1 = new Client("Doe", "John", 30);
Car audiTT = new Car("AV48CE", "TT", "Audi", 80000,
    new DateTime(2012, 2, 21), 211, client1, true);
Car x5 = new Car("FH55EE", "X5", "BMW", 80000,
    new DateTime(2009, 11, 10), 235, client1, true);
client1.AcquisitionDuneVoiture(x5);
client1.AcquisitionDuneVoiture(audiTT);

Client client2 = new Client("Doe", "John", 30);
Car chevrolet = new Car("AV48CE", "Camaro", "Chevrolet", 80000,
    new DateTime(2009, 2, 21), 211, client1, false);
Car peugeot = new Car("FH55EE", "208", "Peugeot", 80000,
    new DateTime(2006, 11, 10), 235, client1, true);
client2.AcquisitionDuneVoiture(chevrolet);
client2.AcquisitionDuneVoiture(peugeot);

Garage garage1 = new Garage("8888775244896");
Garagiste paul = new Garagiste("Dumoulin", "Paul", 42);
Garagiste didier = new Garagiste("Dubois", "Didier", 38);

garage1.EngagerUnGaragiste(paul);
garage1.EngagerUnGaragiste(didier);

garage1.RecupererUneVoitureAReparer(audiTT);
garage1.AssignerUneVoitureAUnGaragiste(audiTT, didier);
didier.ReparationsFinis(audiTT);
garage1.RecuperationDeLaVoitureParLeClient(audiTT, client1);

Console.WriteLine(audiTT.ToString());