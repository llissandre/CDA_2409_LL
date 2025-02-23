using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeExtension
{

    //Méthode d'extension du type int 
    public static class IntegerExtension
    {
        public static bool IsGreaterOrEqual(this int x, int y)  
        {
            return x >= y;
        }
    }
}
