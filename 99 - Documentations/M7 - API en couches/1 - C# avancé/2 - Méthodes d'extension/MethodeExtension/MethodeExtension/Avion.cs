using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeExtension
{
    public class Avion : IVolant
    {
        public void Voler()
        {
            Console.WriteLine("Je vole avec mon moteur");
        }

        public void DeplierLesAiles()
        {
            Console.WriteLine("Je vole comme un avion");
        }
    }
}
