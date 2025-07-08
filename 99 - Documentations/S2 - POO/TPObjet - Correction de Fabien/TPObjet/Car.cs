using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    internal class Car : IDisposable
    {
        private static List<string> Registrations { get; } = new List<string>();

        public static IEnumerable<string> GetRegistrations()
        {
            return Registrations.ToArray();
        }

        #region props
        private string _registration;
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


        public string Model { get; private set; }

        public string Brand { get; private set; }

        public int KLM { get; private set; }

        public DateTime OriginalInServiceDate { get; private set; }

        public Person Owner { get; private set; }

        public int Power {get; private set; }
        #endregion props

        public Car(string registration, string model, string brand, int kLM, DateTime originalInServiceDate, int power, Person owner)
        {
            Registration = registration;
            Model = model;
            Brand = brand;
            KLM = kLM;
            OriginalInServiceDate = originalInServiceDate;
            Power = power;
            Owner = owner;
        }

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

        public void Dispose()
        {
          Registrations.Remove(Registration);
        }
    }
}
