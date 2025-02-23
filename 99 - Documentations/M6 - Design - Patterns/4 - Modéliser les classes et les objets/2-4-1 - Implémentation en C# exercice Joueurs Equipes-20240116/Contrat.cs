namespace JoueursEquipes
{
    public class Contrat
    {
        private Joueur joueur;
        private Equipe equipe;

        private DateOnly dateDebut;
        private DateOnly dateFin;

        public Contrat(Joueur joueur, Equipe equipe, DateOnly dateDebut, DateOnly dateFin)
        {
            this.joueur = joueur;
            this.equipe = equipe;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
    }
}