using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiques
{
    public class Avion : IVolant
    {        
        public void DeplierLesAiles()
        {
            Console.WriteLine("Je déplie mes ailes mécaniques");
        }

        public void Voler()
        {
            Console.WriteLine("J'allume le moteur");
        }
    }
}
