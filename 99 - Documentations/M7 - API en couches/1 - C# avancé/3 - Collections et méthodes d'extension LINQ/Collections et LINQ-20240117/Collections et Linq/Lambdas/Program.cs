using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambdas
{
    //Collections et méthodes d'extension LINQ
    //-----------------------------------------
    // Pour en savoir plus :
    // https://www.tutorialsteacher.com/linq/linq-method-syntax
    // https://www.tutorialsteacher.com/linq/linq-lambda-expression

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 2, 4, 5, 7, 9, 10, 12, 15, 18 };
            Console.WriteLine(String.Join(',', numbers));

            //ForEach est une méthode de List<T>
            //En paramètre, une fonction anonyme --> plusieurs écritures équivalentes
            numbers.ForEach(delegate (int x) { Console.WriteLine(x); });
            numbers.ForEach(x => { Console.WriteLine(x); });
            numbers.ForEach(x => Console.WriteLine(x)); //{} et ; sont inutiles quand il ya une seule instruction

            //FindAll est une méthode de List<T>
            //FindAll a besoin d'une fonction qui est prédicat (qui renvoie un booléen)
            List<int> divBy2 = numbers.FindAll(x => { return (x % 2 == 0); });
            divBy2 = numbers.FindAll(x => (x % 2 == 0)); //même chose avec une écriture simplifiée
           
            //LINQ - Méthodes d'extension qui s'appliquent au type IEnumerable<T>
            //------------------------------------------------------------------
            //Nécessite using System.Linq;

            //Des méthodes finales qui ne renvoient pas un IEnumerable<T> 
            double moyenne = numbers.Average();
            double max = numbers.Max();
            double min = numbers.Min();
            int nbDivBy2 = numbers.Count(x => (x % 2 == 0));

            //Des méthodes qui renvoient un IEnumerable<T>, peuvent être chaînées

            IEnumerable<int> sansDoublons = numbers.Distinct();//Elimination des doublons 
            Console.WriteLine(String.Join(',', sansDoublons));

            IEnumerable<int> squares = numbers.Select(x => x * x); //Projection
            Console.WriteLine(String.Join(',', squares));
         
            IEnumerable<int> pairs = numbers.Where(x => (x > 2 && x < 10)); //Filtre
            Console.WriteLine(String.Join(',', pairs));

            IEnumerable<int> orderedNumbers = numbers.OrderByDescending(x => x); //Tri Console.WriteLine
            Console.WriteLine(String.Join(',', orderedNumbers));

            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var tutos = stringList.Where(s => s.Contains("Tutorials"));

            IEnumerable<Voiture> voitures = new List<Voiture>()
            {
                new Voiture{Couleur="Blanc", Vitesse=80},
                new Voiture{Couleur="Blanc", Vitesse=50},
                new Voiture{Couleur="Blanc", Vitesse=30},
                new Voiture{Couleur="Rouge", Vitesse=130}
            };

            IEnumerable<Voiture> result = voitures.Where(v => (v.Vitesse > 50)).OrderBy(v => v.Vitesse);

            Console.ReadKey();
        }

        #region Méthodes
        static void Affiche<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        #endregion 
    }
}
