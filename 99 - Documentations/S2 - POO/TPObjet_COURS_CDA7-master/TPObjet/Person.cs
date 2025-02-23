using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    /// <summary>
    /// Représente une personne
    /// </summary>
    internal class Person : IDisposable
    {

        /// <summary>
        /// Liste de voitures personnelles
        /// </summary>
        List<Car> _cars = new List<Car>();

        /// <summary>
        /// Nombre d'instances de personne en cours
        /// </summary>
        public static int CompteurInstance { get; private set; }

        /// <summary>
        /// Liste des ages des personnes
        /// </summary>
        private static List<int> Ages { get; } = new List<int>();

        /// <summary>
        /// Récupère une copie de la liste des ages
        /// </summary>
        /// <returns>Copie de la liste des ages de toutes les personnes instanciées</returns>
        public static IEnumerable<int> GetAges()
        {
            return Ages.ToArray();
        }

        /// <summary>
        /// Calcule la moyenne des ages des instances de personnes
        /// </summary>
        /// <returns>Renvoie la moyenne des ages</returns>
        public static double GetAverageAgeStatic()
        {
            return Ages.Average();
        }

        #region Props
        /// <summary>
        /// Nom de la personne
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Age de la personne
        /// </summary>
        private int _Age;
        /// <summary>
        /// Age de la personne
        /// </summary>
        public int Age
        {
            get { return _Age; }
            private set
            {
                //Infos :(value = nouvelle valeur)

                //Modification de la propriété de classe
                Ages.Remove(value);
                Ages.Add(value);

                //Modification de la propriété d'instance
                _Age = value;
            }
        }
        #endregion

        /// <summary>
        /// Constructeur de la classe personne
        /// </summary>
        /// <param name="name">Nom de la nouvelle personne</param>
        /// <param name="firstName">Prénom de la nouvelle personne</param>
        /// <param name="age">Age de la nouvelle personne</param>
        public Person(string name, string firstName, int age)
        {
            Name = name;
            FirstName = firstName;
            Ages.Add(age);
            Age = age;

            //CompteurInstance = CompteurInstance + 1;
            CompteurInstance += 1;
        }

        #region Méthodes
        /// <summary>
        /// Récupère toutes les informations liées à une personne
        /// </summary>
        /// <returns>Renvoie une chaîne de caractère qui rassemble toutes les informations de la personne</returns>
        public string Print()
        {
            return $"{Name} {FirstName} ({Age} ans)";
        }

        public void Dispose()
        {
            Ages.Remove(Age);
            CompteurInstance -= 1;
        }


        public void AcquisitionDuneVoiture(Car car)
        {
            if (!_cars.Contains(car))
            {
                _cars.Add(car);
            }

        }

        public void VenteDuneVoiture(Car car)
        {
            if (_cars.Contains(car))
            {
                _cars.Remove(car);
            }
        }
        #endregion
    }
}
