using System;
using System.Collections;
using System.Collections.Generic;

namespace Generiques
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 - Utilisation de collections génériques
            //-----------------------------------------

            //ArrayList n'est pas générique, on dit qu'elle est faiblement typé
            //Tout type d'objet peut y être stocké --> c'est bien le problème !
            //ArrayList est abandonné au profit de List<T>
            ArrayList liste = new ArrayList();
            liste.Add(1);
            liste.Add("Hello");
            liste.Add(new Voiture());
            liste.Add(new Voiture { Couleur = "Noir", Marque = "Renault" });
            Afficher(liste);

            //List<T> est une liste générique fortement typée
            //List<T> accepte uniquement des objets de type T 
            //List<T> est dans l'espace de nom System.Collections.Generic
            List<int> numbers = new List<int>() { 2, 3, 5, 8, 9, 1 };
            numbers.Add(1);
            //entiers.Add("Hello"); //Est interdit dès la compilation

            List<string> noms = new List<string>();
            noms.Add("Hello");

            List<Voiture> voitures = new List<Voiture>();
            voitures.Add(new Voiture());

            //2 - Méthodes génériques
            //------------------------

            //Un premier exemple : Méthode Afficher
            //Tout se passe comme si on avait écrit autant de signatures différentes
            Afficher<int>(1);
            Afficher<string>("Hello");
            Afficher<Voiture>(new Voiture());

            //Il n'est pas nécessaire de préciser le type, il peut être déduit
            Afficher(1);
            Afficher("Hello");
            Afficher(new Voiture());

            //Autre exemple : Méthode Permuter
            int i1 = 10;
            int i2 = 5;
            Console.WriteLine($" i1 = {i1} i2 = {i2}");
            Permuter<int>(ref i1, ref i2);
            Console.WriteLine($" i1 = {i1} i2 = {i2}");

            Voiture v1 = new Voiture();
            Voiture v2 = new Voiture { Couleur = "Noir", Marque = "CX", Vitesse = 80 };
            Console.WriteLine($" v1 = {v1} v2 = {v2}");
            Permuter<Voiture>(ref v1, ref v2);
            Console.WriteLine($" v1 = {v1} v2 = {v2}");

            //3 - Classe générique : MaListeGenerique<T>
            //------------------------------------------

            //Ici, une liste d'entiers, le type des objets lors de la déclaration
            MaListeGenerique<int> entiers = new MaListeGenerique<int>(4);
            entiers.Ajouter(1);
            entiers.Ajouter(3);
            entiers.Ajouter(5);
            entiers.Ajouter(7);
            entiers.Ajouter(9);

            Console.WriteLine(entiers.ObtenirElement(2));
            Console.WriteLine(entiers.ObtenirElement(6));

            MaListeGenerique<int> sousListe = entiers.ObtenirNPremiersElements(3);

            //4 - Restrictions sur le type T
            //------------------------------
            Oiseau oiseau = CreerIVolant<Oiseau>();
            Avion avion = CreerIVolant<Avion>();

            //Nullable<T> : un type générique avec restriction (T doit être une struct) 
            //              s'applique à tous les types qui sont des struct (types 
            //              int i = null; //N'est pas possible car un int ne peut pas prendre la valeur null 

            Nullable<int> i = null;
            if(i.HasValue) 
            {
                Console.WriteLine(i.Value);
            }

            //Plus simplement, on préférera écrire
            int? j = null; //Nullable<int> j = null;
            if (j.HasValue)
            {
                Console.WriteLine(j.Value);
            }         
            
            Console.ReadKey();
        }

        #region Méthodes génériques

        //Exemple : Méthode générique Afficher<T>
        //Toute méthode qui prend un argument de type object est candidate à devenir générique
        static void Afficher<T>(T t) //Il est conventionnel d'utiliser T pour désigner le type
        {
            Console.WriteLine($"{t.GetType()} {t.ToString()}");
        }

        //Autre exemple : méthode générique Permuter<T>
        //Une fois le type T précisé entre les chevrons, le type T s’utilise dans la méthode comme n’importe quel autre type
        static void Permuter<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }

        //Créer : une méthode de fabrique d'objets IVolant
        //Restrictions : on pose des contraintes sur le type T
        //On veut le type T implémente l'interface IVolant et ait un constructeur par défaut 
        public static T CreerIVolant<T>() where T : IVolant, new()
        {
            T t = new T(); //On est certain que le type T a un constructeur par défaut
            //On peut appeler ces méthodes car T implémente l'interface IVolant
            t.DeplierLesAiles();
            t.Voler();
            return t;
        }
        #endregion
    }
}
