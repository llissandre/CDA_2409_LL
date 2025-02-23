using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeExtension
{
    //Plus fort : une méthode d'extension pour une interface 
    public static class IVolantExtension
    {
        public static void Atterir(this IVolant volant)
        {
            Console.WriteLine("J'atterris");
        }
    }
}
