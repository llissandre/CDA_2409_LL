~~~ java
Cheval belino1 = new Cheval();
belino1.Brouter();

Transports belino2 = new Cheval();
belino2.BaisserLaVitesse();

IMotorise c = new Ferry();
c.ConsommerEnergie();
Avion a = new Avion();
a.ConsommerEnergie();

List<IMotorise> motorises = new List<IMotorise>;
motorises.Add(c);
motorises.Add(new Rasoir());
foreach(IMotorise m in motorises)
{
    m.ConsommerEnergie();
}

public abstract Transport
{
    private int vitesseEnKm;
    
    public Transport(int vitesseEnKm)
    {
        this.vitesseEnKm = vitesseEnKm;      
    }

    public abstract void Avancer();
}


public class Ferry :TransportMaritine, IMotorise
{
    private int nbConteneur;

    public Ferry(int vitesseEnKm, int nbConteneur)
        : base(vitesseEnKm);
    {
        this.nbConteneur = nbConteneur;       
    }

    public override void Avancer();
}
~~~