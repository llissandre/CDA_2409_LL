using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6bis
{
    internal class E06bisProgram
    {
        static void Main(string[] args)
        {
            //affiche sur la console : "Rentrer un nombre entier:"
            Console.WriteLine("Rentrez un nombre entier :");

            //récupère l'entier donné par l'utilisateur
            //parse la chaine de caractère "N" en un entier "Nombre"
            int Nombre = int.Parse(Console.ReadLine());

            //vérifie si le nombre est pair
            if (Nombre % 2 == 0) // comparer le modulo de Nombre par 2 avec 0
            {
                //écrire pair si le nombre est pair
                Console.WriteLine("Pair");
            }
            else
            {
                //écrire impair si le nombre est impaire
                Console.WriteLine("Impair");
            }
            // permet de laisser la fenêtre de la console ouverte
            Console.ReadLine();
        }
    }
}
