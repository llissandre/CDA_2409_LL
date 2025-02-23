namespace JoueursEquipes
{
    public class Equipe
    {
        private string nom;
        private List<Contrat> contrats = new List<Contrat>();

        public Equipe(string nom)
        {
            this.nom = nom;
        }

        public void ajouterContrat(Contrat contrat)
        {
            contrats.Add(contrat);
        }

        public void retirerContrat(Contrat contrat)
        {
            contrats.Remove(contrat);
        }

    }
}