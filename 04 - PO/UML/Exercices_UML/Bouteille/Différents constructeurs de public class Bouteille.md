~~~c#
public class Bouteille
{
        //attributs
        private float contenanceEnLitre;
        private float contenuEnLitre;
        private bool estOuverte;

        //constructeurs

        //constructeur par defaut
        public Bouteille()
        {
            this.contenanceEnLitre = 1;
            this.contenuEnLitre = 1;
            this.estOuverte = false;
        }

 	public Bouteille():this(1, 1, false)
        {
	}

        //constructeur classique
        public Bouteille(float contenanceEnLitre,
                         float contenuEnLitre,
                         bool estOuverte)
        {
            this.contenanceEnLitre = contenanceEnLitre;
            this.contenuEnLitre = contenuEnLitre;
            this.estOuverte = estOuverte;
        }

        //constructeur hybride classique defaut
        public Bouteille(float contenanceEnLitre,
                         float contenuEnLitre)
        :this(contenanceEnLitre, contenuEnLitre, false)
        {
        }

        //constructeur par clonage
        public Bouteille(Bouteille bouteilleACopier)
        {
            this.contenanceEnLitre = bouteilleACopier.contenanceEnLitre;
            this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
            this.estOuverte = bouteilleACopier.estOuverte;
        }

    	public Bouteille(Bouteille bouteilleACopier)
	:this(bouteilleACopier.contenanceEnLitre, bouteilleACopier.contenuEnLitre, bouteilleACopier.estOuverte)
        {
        }
}
~~~