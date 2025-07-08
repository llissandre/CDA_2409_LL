using System;

namespace Generiques
{
   

    /// <summary> 
    /// Cette classe réalise une implémentation basique d'une liste générique 
    /// La liste stocke les éléments du type T dans un tableau
    /// Le tableau s'agrandit quand le tableau est plein
    /// </summary>
    /// <typeparam name="T">Type des éléments de la liste</typeparam>
    public class MaListeGenerique<T>
    {
        private int capacite;
        private T[] tableau;
        private int nbElements ;

        /// <summary>
        /// Crée une liste avec une capacité par défaut (10)
        /// </summary>
        //public MaListeGenerique() : this(10) { }        

        /// <summary>
        /// Crée une liste générique
        /// </summary>
        /// <param name="capacite">capacité (égale à 10 par défaut)</param>
        public MaListeGenerique(int capacite=10) //La capacité par défaut est 10
        {
            this.capacite = capacite;
            tableau = new T[capacite];
            nbElements = 0;
        }

        /// <summary>
        /// Ajoute un élément de type T à la liste
        /// </summary>
        /// <param name="element">Element à ajouter</param>
        public void Ajouter(T element)
        {
            if (nbElements >= capacite) //Le tableau est plein            
            {
                capacite *= 2; // La capacité est doublée
                T[] copie = new T[capacite]; //Le tableau est agrandi 
                for (int i = 0; i < nbElements; i++)
                {
                    copie[i] = tableau[i];
                }
                tableau = copie; 
            }

            //Dans tous les cas, l'élément est ajouté
            tableau[nbElements] = element;
            nbElements++;
        }

        /// <summary>
        /// Récupère un élément dans la liste
        /// </summary>
        /// <param name="indice">indice recherché</param>
        /// <returns>L'élément trouvé ou la valeur par défaut du type des éléments</returns>
        public T ObtenirElement(int indice)
        {
            //if (indice < 0 || indice >= nbElements)
            //    return default(T); //Renvoie la valeur par défaut du type T

            //return tableau[indice];

            return (indice < 0 || indice >= nbElements) ? default(T) : tableau[indice];
        }

        //public IEnumerable<T> ObtenirNPremiersElements (int n)
        //{
        //    n = (n< 0 || n > nbElements) ? nbElements : n;
            
        //    T[] resultat = new T[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        resultat[i] = tableau[i];
        //    }
        //    return resultat;
        //}

        /// <summary>
        /// Renvoie une sous-liste avec les n premiers éléments contenus dans la liste
        /// </summary>
        /// <param name="n">nombre d'éléments à retourner</param>
        /// <returns>La sous-liste ou la liste complète si n est invalide</returns>
        public MaListeGenerique<T> ObtenirNPremiersElements(int n)
        {
            //Si n est invalide, on renvoie toute la liste
            n = (n < 0 || n > nbElements) ? nbElements : n;

            MaListeGenerique<T> resultat = new MaListeGenerique<T>(n);
            for (int i = 0; i < n; i++)
            {
                resultat.Ajouter(tableau[i]);
            }
            return resultat;
        }

        /// <summary>
        /// Renvoie le nombre d'éléments présents dans la liste
        /// </summary>
        /// <returns>Nombre d'éléments de la liste</returns>
        public int NbElements()
        {
            return nbElements;
        }
    }
}
