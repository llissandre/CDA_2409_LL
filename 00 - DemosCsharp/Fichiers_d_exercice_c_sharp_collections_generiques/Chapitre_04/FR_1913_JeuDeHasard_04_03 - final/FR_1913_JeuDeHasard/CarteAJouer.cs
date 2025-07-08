namespace FR_1913_JeuDeHasard
{
    public enum Couleur
    {
        Coeur,
        Carreau,
        Trefle,
        Pique
    }

    public abstract class CarteAJouer : Carte
    {
        public CarteAJouer(Couleur couleur)
        {
            Couleur = couleur;
        }
        public Couleur Couleur
        {
            get; private set;
        }
    }
}
