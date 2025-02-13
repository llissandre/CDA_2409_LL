///////////////////////////////////////////////////////////
//  Bouteille.cs
//  Implementation of the Class Bouteille
//  Generated by Enterprise Architect
//  Created on:      06-f�vr.-2025 15:36:59
//  Original author: LLissandre
///////////////////////////////////////////////////////////

namespace ClassLibraryExercices
{
    public class Bouteille
    {
        /// <summary>
        /// D�claration des variables
        /// </summary>
        private float _contenanceEnLitre;
        private float _contenuEnLitre;
        private bool _estOuverte;

        /// <summary>
        /// constructeurs
        /// Un constructeur est, en programmation orient�e objet, une fonction particuli�re appel�e lors de l'instanciation.
        /// Elle permet d'allouer la m�moire n�cessaire � l'objet et d'initialiser ses attributs.
        /// </summary>


        //constructeurs par defaut
        /// <summary>
        /// Le terme � constructeur par d�faut � fait r�f�rence � un constructeur qui n'accepte aucun argument d'entr�e.
        /// Chaque instance de classe doit �tre initialis�e avec les m�mes valeurs dans un constructeur par d�faut.
        /// </summary>

        //public Bouteille()
        //{
        //    _contenanceEnLitre = 1;
        //    _contenuEnLitre = 1;
        //    _estOuverte = false;
        //}

        // Un constructeur peut appeler un autre constructeur dans le m�me objet � l�aide du mot cl� this. Comme base, this peut �tre utilis� avec ou sans param�tres,
        // et tous les param�tres dans le constructeur sont disponibles comme param�tres pour this ou comme partie d�une expression.
        public Bouteille()
            //:this : Interd�pendance entre constructeurs
            : this(1f, 1, false) { }


        /// Constructeur classique
        /// <param name="contenanceEnLitre"></param>
        /// <param name="contenuEnLitre"></param>
        /// <param name="estOuverte"></param>
        public Bouteille(float contenanceEnLitre, float contenuEnLitre, bool estOuverte)
        {
            if (contenanceEnLitre < 0)
            {
                //L�instruction throw l�ve une exception :
                throw new ArgumentException("La contenance en litre doit �tre sup�rieure � 0 !"
                    , nameof(contenanceEnLitre));
            }

            if (contenuEnLitre < 0)
            {
                //L�instruction throw l�ve une exception :
                throw new ArgumentException("Le contenu en litre doit �tre sup�rieure � 0 !"
                    , nameof(contenuEnLitre));
            }

            _contenanceEnLitre = contenanceEnLitre;
            _contenuEnLitre = contenuEnLitre;
            _estOuverte = estOuverte;
        }


        //constructeur hybride classique
        /// <param name="contenanceEnLitre"></param>
        /// <param name="contenuEnLitre"></param>
        public Bouteille(float contenanceEnLitre, float contenuEnLitre)
            //:this : Interd�pendance entre constructeurs
            : this(contenanceEnLitre, contenuEnLitre, false)
        {
        }
        

        // Constructeurs par clonage
        /// <summary>
        /// Ils permettent de copier les propri�t�s d�un objet existant dans la nouvelle instance.
        /// En copiant des variables d'un autre objet, ce constructeur g�n�re un objet. 
        /// Son objectif principal est de d�finir les valeurs d'une nouvelle instance sur celles d'une instance existante.
        /// </summary>
        /// <param name="bouteilleACopier"></param>
        //public Bouteille(Bouteille bouteilleACopier)
        //{
        //    _contenanceEnLitre = bouteilleACopier._contenanceEnLitre;
        //    _contenuEnLitre = bouteilleACopier._contenuEnLitre;
        //    _estOuverte = bouteilleACopier._estOuverte;
        //}
        public Bouteille(Bouteille bouteilleACopier)
            //:this : Interd�pendance entre constructeurs
            : this(bouteilleACopier._contenanceEnLitre, bouteilleACopier._contenuEnLitre, bouteilleACopier._estOuverte) { }


        /// <summary>
        /// Cette m�thode est principalement impl�ment�e pour lib�rer des ressources non manag�es.
        /// </summary>
        public virtual void Dispose() { }


        /// Fonction Ouvrir()
        /// <summary>
        /// Utilis�e pour ouvrir la bouteille
        /// </summary>
        /// <returns>Retourne un bool�en, "true" si la m�thode � permis d'ouvrir la bouteille, sinon "false"</returns>
        public bool Ouvrir()
        {
            if (_estOuverte == false)
            {
                _estOuverte = true;
                return true;
            }
            return false;
        }


        /// Fonction Fermer()
        /// <summary>
        /// Utilis�e pour fermer la bouteille
        /// </summary>
        /// <returns>Retourne un bool�en, "true" si la m�thode � permis de fermer la bouteille, sinon "false"</returns>
        public bool Fermer()
        {
            if (_estOuverte == true)
            {
                _estOuverte = false;
                return true;
            }
            return false;
        }


        /// Fonction Vider()
        /// <summary>
        /// Utilis�e pour vider compl�tement la bouteille
        /// </summary>
        /// <returns>Renvoie vers la m�thode Vider(quantiteEnLitre)</returns>
        public bool Vider()
        {
            //if (_estOuverte == true && _contenuEnLitre > 0)
            //{
            //    _contenuEnLitre = 0;
            //    return true;
            //}
            //return false;

            return Vider(_contenanceEnLitre);
        }


        /// Fonction Vider(quantiteEnLitre)
        /// <summary>
        /// Utilis�e pour vider la bouteille d'une quantit� d�finie en litre
        /// </summary>
        /// <param name="quantiteEnLitre"></param>
        /// <returns>Retourne un bool�en, "true" si la m�thode � permis de vider la bouteille d'une quantit� d�finie en litre,
        /// sinon "false"</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool Vider(float quantiteEnLitre)
        {
            if (quantiteEnLitre < 0)
            {
                //L�instruction throw l�ve une exception :
                throw new ArgumentException(nameof(quantiteEnLitre),
                "La quantit� d'eau � vider doit �tre sup�rieure � 0 !");
            }

            if (_estOuverte == true && quantiteEnLitre > 0 && _contenuEnLitre - quantiteEnLitre >= 0)
            {
                _contenuEnLitre -= quantiteEnLitre;
                return true;
            }
            return false;
        }


        /// Fonction Remplir()
        /// <summary>
        /// Utilis�e pour remplir compl�tement la bouteille 
        /// </summary>
        /// <returns>Renvoie vers la m�thode Remplir(quantiteEnLitre)</returns>
        public bool Remplir()
        {
            //if (_estOuverte == true && _contenuEnLitre < _contenanceEnLitre)
            //{
            //    _contenuEnLitre = _contenanceEnLitre;
            //    return true;
            //}
            //return false;

            return Remplir(_contenanceEnLitre);
        }


        /// Fonction Remplir(quantiteEnLitre)
        /// <summary>
        /// Utilis�e pour remplir la bouteille d'une quantit� d�finie en litre
        /// </summary>
        /// <param name="quantiteEnLitre"></param>
        /// <returns>Retourne un bool�en, "true" si la m�thode � permis de remplir la bouteille d'une quantit� d�finie en litre, sinon "false"</returns>
        /// <exception cref="ArgumentException"></exception>
        public bool Remplir(float quantiteEnLitre)
        {
            if (quantiteEnLitre < 0)
            {
                //L�instruction throw l�ve une exception :
                throw new ArgumentException("La quantit� d'eau � remplir doit �tre sup�rieure � 0 !"
                    , nameof(quantiteEnLitre));
            }

            if (_estOuverte == true && quantiteEnLitre > 0 && _contenuEnLitre + quantiteEnLitre <= _contenanceEnLitre)
            {
                _contenuEnLitre += quantiteEnLitre;
                return true;
            }
            return false;
        }


        /// Fonction ToString()
        /// <summary>
        /// La m�thode toString est d�finie dans la classe Object; en cons�quence toutes les classes C# en h�rite.
        /// Lorsqu'on d�finit une classe, il peut �tre tr�s utile de red�finir la m�thode toString afin de donner une description satisfaisante des objets de cette classe.
        /// Beaucoup de classes de l'API red�finissent la m�thode toString.
        /// </summary>
        /// <returns>La fonction renvoie une cha�ne de caract�res servant � d�crire l'objet concern�.</returns>
        public override string ToString()
        {
            return "Contenance en litre : " + _contenanceEnLitre
                + ", contenu en litre : " + _contenuEnLitre + ", est ouvert : " + _estOuverte;

            //Renvoie le nom et le chemin de la classe, et une cha�ne de caract�res servant � d�crire l'objet concern�.
            //return base.ToString() + " : Contenance en litre : " + _contenanceEnLitre
            //    + ", contenu en litre : " + _contenuEnLitre + ", est ouvert : " + _estOuverte;
        }
    }
}