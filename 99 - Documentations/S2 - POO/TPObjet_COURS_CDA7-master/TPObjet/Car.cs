using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    /// <summary>
    /// Représente une voiture
    /// </summary>
    internal class Car : IDisposable
    {
        /// <summary>
        /// Liste de toutes les plaques d'immatriculations
        /// </summary>
        private static List<string> Registrations { get; } = new List<string>();

        /// <summary>
        /// Récupère la liste des plaques d'immatriculations
        /// </summary>
        /// <returns>Copie de la liste des plaques d'immatriculations de toutes les instances</returns>
        public static IEnumerable<string> GetRegistrations()
        {
            return Registrations.ToArray();
        }

        #region props
        /// <summary>
        /// Immatriculation de la voiture
        /// </summary>
        private string _registration;

        /// <summary>
        /// Immatriculation de la voiture
        /// </summary>
        public string Registration { 
            get { return _registration; }
            set { 
                if(Registrations.Contains(value))
                {
                    _registration =  "";
                    Registrations.Remove(value);
                }
                //Registrations.Exists(
                //    (valeuritem) =>  {return SearchRegistrationWithChar(valeuritem, 'A'); });
                else {
                    Registrations.Add(value);
                    _registration = value;
                }
            } }

        public bool AReparer { get; private set; }

        //public bool SearchRegistrationWithChar(string registration, char c)
        //{
        //    bool trouve = false;
        //    for(int i = 0; i < Registration.Length; i++)
        //    {
        //        trouve = Registration[i] == c;
        //        if(trouve ==true )  {
        //            break;
        //        }
        //    }
        //    return trouve;
        //}

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Marque de la voiture
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Compteur kilométrique de la voiture
        /// </summary>
        public int KLM { get; private set; }

        /// <summary>
        /// Date de mise en service de la voiture 
        /// </summary>
        public DateTime OriginalInServiceDate { get; private set; }

        /// <summary>
        /// Propriétaire de la voiture
        /// </summary>
        public Person Owner { get; private set; }

        /// <summary>
        /// Puissance de la voiture
        /// </summary>
        public int Power {get; private set; }
        #endregion props

        /// <summary>
        /// Construsteur complet de la voiture 
        /// </summary>
        /// <param name="registration">Immatriculation</param>
        /// <param name="model">Modèle</param>
        /// <param name="brand">Marque</param>
        /// <param name="kLM">Compteur kilométrique actuel de la voiture</param>
        /// <param name="originalInServiceDate">Date de mise en service de la voiture</param>
        /// <param name="power">Puissance de la voiture</param>
        /// <param name="owner">Propriétaire de la voiture</param>
        public Car(string registration, string model, string brand, int kLM, DateTime originalInServiceDate, int power, Person owner, bool aReparer)
        {
            Registration = registration;
            Model = model;
            Brand = brand;
            KLM = kLM;
            OriginalInServiceDate = originalInServiceDate;
            Power = power;
            Owner = owner;
            AReparer = aReparer;
        }

        /// <summary>
        /// Récupére les informations de la voiture sous forme de chaîne de caractères
        /// </summary>
        /// <returns>Les informations de la voiture</returns>
        public string Print()
        {
            if (Owner is not null)
            {
                return
                    $"{Registration} ({Model} - {Brand}) :  {KLM} - {OriginalInServiceDate} - {Owner.Print()}";
            }
            else
            {
                return
                     $"{Registration} ({Model} - {Brand}) :  {KLM} - {OriginalInServiceDate} - Pas de propriétaire";
            }
        }

        /// <summary>
        /// Permet de réparer le véhicule
        /// </summary>
        public void Reparer()
        {
            AReparer = false;
        }

        /// <summary>
        /// Permet de changer le propriétaire de la voiture
        /// </summary>
        /// <param name="person">Nouveau propriétaire</param>
        public void ChangementDeProprietaire(Person person)
        {
            if(Owner is not null)
            {
                Person oldOwner = Owner;
                person.AcquisitionDuneVoiture(this);
                oldOwner.VenteDuneVoiture(this);
            }
        }

        public void Dispose()
        {
          Registrations.Remove(Registration);
        }
    }
}
