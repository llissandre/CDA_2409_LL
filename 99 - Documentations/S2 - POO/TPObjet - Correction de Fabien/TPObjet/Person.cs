using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPObjet
{
    internal class Person : IDisposable
    {
        public static int CompteurInstance { get;  private set; }
        private static List<int> Ages { get; } = new List<int>();

        public static IEnumerable<int> GetAges()
        {
            return Ages.ToArray();
        }
        
        public static double GetAverageAgeStatic()
        {
           return Ages.Average();
        }

        #region Props
        public  string Name { get; private set; }

        public string FirstName { get; private set; }
        
        private int _Age;
        public int Age { 
            get { return _Age; }
            private set {
                //Infos :(value = nouvelle valeur)

                //Modification de la propriété de classe
                Ages.Remove(value);
                Ages.Add(value);
                
                //Modification de la propriété d'instance
                _Age = value;
            }
        }
        #endregion

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
        public string Print()
        {
            return $"{Name} {FirstName} ({Age} ans)";
        }

        public void Dispose()
        {
            Ages.Remove(Age);
            CompteurInstance -= 1;
        }
        #endregion
    }
}
