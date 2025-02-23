using System;

namespace MethodeExtension
{
    class Program
    {
        //les Méthodes d'extension permettent d'étendre un type existant
        //qu'on ne veut pas ou peut pas modifier

        //Une méthode d'extension est définie dans une classe statique
        //                             comme une méthode statique
        //                             this désigne l'instance du type sur laquelle elle s'applique
        //Une méthode d'extension s'utilise comme une méthode d'instance
        //Une méthode d'extension est repérable grâce à un icône avec flèche vers le bas       

        static void Main(string[] args)
        {
            String maChaine = "Hello";
            String maChaineEncodee = maChaine.Encoder();
            Console.WriteLine(maChaineEncodee.Decoder());

            string chaine1 = "Bonjour, ceci est un test !";
            Console.WriteLine(chaine1.WordCount());
            Console.WriteLine(chaine1.WordCount(new char[] { ' ', '!', ',', '!' }));

            int i1 = 1;
            int i2 = 3;
            Console.WriteLine(i1.IsGreaterOrEqual(i2));
            Console.WriteLine(i2.IsGreaterOrEqual(i1));

            //Quand une méthode d'extension est définie pour une interface
            //Elle est disponible pour tous les objets des classes qui implémentent cette interface
            //Ici, Oiseau et Avion implémentent l'interface IVolant
            //Les objets de ces 2 classes disposent de la méthode d'extension Atterrir définie pour l'interface IVolant

            IVolant oiseau = new Oiseau();
            oiseau.DeplierLesAiles();
            oiseau.Voler();
            oiseau.Atterir();

            Avion avion = new Avion();
            avion.Atterir();

            Console.ReadLine();
        }
    }
}
