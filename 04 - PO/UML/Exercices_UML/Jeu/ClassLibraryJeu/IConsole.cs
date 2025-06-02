using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu
{
    public interface IConsole
    {
        void Ecrire(string message);
        void EcrireLigne(string message);
    }
}
