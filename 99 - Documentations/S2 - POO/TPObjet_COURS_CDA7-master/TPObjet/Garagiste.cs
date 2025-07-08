using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    /// <summary>
    /// Représente un mécanicien dans le garage
    /// </summary>
    internal class Garagiste : Person
    {
        /// <summary>
        /// Liste des voiture à réparer par le garagiste
        /// </summary>
        private List<Car> _voituresAReparer = new List<Car>();

        /// <summary>
        /// Constructeur de Garagiste
        /// </summary>
        /// <param name="name"> Nom du Garagiste</param>
        /// <param name="firstName">Prénom du Garagiste</param>
        /// <param name="age">Age du Garagiste</param>
        public Garagiste(string name, string firstName, int age) 
        : base(name, firstName, age)
        {

        }

        /// <summary>
        /// Permet d'ajouter une tache au garagiste
        /// </summary>
        /// <param name="car">La voiture à réparer</param>
        public void AjouterUneVoitureAReparer(Car car)
        {
            _voituresAReparer.Add(car);
        } 

        /// <summary>
        /// Permert de valider les réparations d'une voiture
        /// </summary>
        /// <param name="car">Voiture réparer</param>
        public void ReparationsFinis(Car car)
        {
            car.Reparer();
            _voituresAReparer.Remove(car);
        }
    }
}
