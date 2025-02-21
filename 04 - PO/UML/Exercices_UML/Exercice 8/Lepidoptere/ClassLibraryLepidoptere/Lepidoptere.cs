namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        /// <summary>
        /// Déclaration du string espece
        /// </summary>
        private string espece;

        /// <summary>
        /// Déclaration du StadeDEvolution sonStadeCourant
        /// </summary>
        private StadeDEvolution sonStadeCourant;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Lepidoptere()
        { }

        /// <summary>
        /// Constructeur classique hybride
        /// </summary>
        /// <param name="espece"></param>
        public Lepidoptere(string espece)
        {
            this.espece = espece;
            sonStadeCourant = new Oeuf();
        }

        public Lepidoptere(string espece):this()
        {
        }

            /// <summary>
            /// Méthode SeDeplacer()
            /// </summary>
            public void SeDeplacer()
        {
            this.sonStadeCourant.SeDeplacer();
        }

        /// <summary>
        /// Méthode SeMetamorphoser
        /// </summary>
        public void SeMetamorphoser()
        {
            this.sonStadeCourant = this.sonStadeCourant.SeMetamorphoser();
            //a = a + 1;
            //a = a.Plus(1);
        }
    }
}
