using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExercices
{
    public class ConsoleDeSortie : IConsole
    {
        public void Ecrire(string message)
        {
            Console.Write(message);
        }

        public void EcrireLigne(string message)
        {
            Console.WriteLine(message);
        }
    }
}
