using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiques
{
    public class Oiseau : IVolant
    {
       
        public void DeplierLesAiles()
        {
            Console.WriteLine("Je déplie mes ailes d'oiseau");
        }

        public void Voler()
        {
            Console.WriteLine("Je bats des ailes");
        }
    }
}
