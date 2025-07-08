using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice_LINQ
{
    class Program
    {
        //Exercice - Requêtes LINQ sur des collections d'objets en utilisant les méthodes d'extension de IEnumerable<T>

        // Pour en savoir plus :
        // - LINQ Method Syntax : https://www.tutorialsteacher.com/linq/linq-method-syntax
        // - Anatomy of lambda Expression : https://www.tutorialsteacher.com/linq/linq-lambda-expression

        static void Main(string[] args)
        {
            JeuDonnees.Afficher(
               "Jeu de données",
               JeuDonnees.GetPersonnes()
            );

            // Trouver toutes les personnes dont le nom commence par A

            JeuDonnees.Afficher(
                "Les personnes dont le nom commence par A",
                JeuDonnees.GetPersonnes().Where(p => p.Nom.ToUpper().StartsWith('A'))
            );

            JeuDonnees.Afficher(
                "Les personnes dont le nom commence par Z",
                JeuDonnees.GetPersonnes().Where(p => p.Nom.ToUpper().StartsWith('Z'))
            );

            // Trouver les personnes majeures 

            JeuDonnees.Afficher(
                "Les personnes majeures",
                JeuDonnees.GetPersonnes().Where(p => (DateTime.Today.Year - p.DateNaissance.Year) >= 18)
            );

            //On appelle une fonction EstMajeur de la classe Personne
            JeuDonnees.Afficher(
               "Les personnes majeures",
               JeuDonnees.GetPersonnes().Where(p => p.EstMajeur()).Select(p => p.Nom)
           );

            //  Existe-t-il une femme majeure

            JeuDonnees.Afficher(
                "Existe-t-il une femme majeure ?",
                JeuDonnees.GetPersonnes().Any(p => (p.Age >= 18 && p.Sexe == Sexe.FEMININ))
            );

            //  Toutes les personnes ayant une voiture verte
            JeuDonnees.Afficher(
               "Toutes les personnes ayant une voiture verte",
                JeuDonnees.GetPersonnes().Where(p => p.Voitures.Any(v => v.Couleur.Equals("Vert")))
            );

            //Nom et prénom des personnes triés par ordre alphabétique
            JeuDonnees.Afficher(
               "nom et prenom des personnes",
                JeuDonnees.GetPersonnes().OrderBy(p => p.Nom).ThenBy(p => p.Prenom).Select(p => p.Nom.ToUpper() + ' ' + p.Prenom)
            );

            //Quel est l'age moyen des personnes
            JeuDonnees.Afficher(
               "Age moyen des personnes",
                JeuDonnees.GetPersonnes().Average(p => p.Age)
            );

            //Trouver toutes les couleurs des voitures 
            //SelectMany renvoie le résultat en une seule liste 
            JeuDonnees.Afficher(
               "Toutes les couleurs des voitures ",
                JeuDonnees.GetPersonnes().SelectMany(p => p.Voitures).Select(v => v.Couleur).Distinct()
            );

            //Fournir pour chaque couleur le nombre de voitures
            //Requête de Julien
            JeuDonnees.Afficher(
               "Nb de voitures par couleur",
            JeuDonnees.GetPersonnes().SelectMany(p => p.Voitures).Select(v => v.Couleur).Distinct().Select(c => (c, JeuDonnees.GetPersonnes().SelectMany(p => p.Voitures).Count(v => v.Couleur == c)))
            );

            //Avec un group by
            JeuDonnees.Afficher(
                "Pour chaque couleurs le nombre de voiture",
                JeuDonnees.GetPersonnes().SelectMany(p => p.Voitures).GroupBy(v => v.Couleur).Select(g => (g.Key, g.Count()))
            );

            //Quelle est la personne qui a le plus de voiture ?
            JeuDonnees.Afficher(
               "la personne qui a le plus de voitures",
                JeuDonnees.GetPersonnes().OrderByDescending(p => p.Voitures.Count()).FirstOrDefault()
           );

            JeuDonnees.Afficher(
               "Les 3 personnes qui ont le plus de voitures",
                JeuDonnees.GetPersonnes().OrderByDescending(p => p.Voitures.Count()).Take(3)
           );

            //Les personnes qui n'ont pas de voiture
            JeuDonnees.Afficher(
                "Personnes n'ayant pas de voiture",
                 JeuDonnees.GetPersonnes().Where(p => p.Voitures.Count() == 0)
             );

            Console.ReadKey();
        }
    }
}
