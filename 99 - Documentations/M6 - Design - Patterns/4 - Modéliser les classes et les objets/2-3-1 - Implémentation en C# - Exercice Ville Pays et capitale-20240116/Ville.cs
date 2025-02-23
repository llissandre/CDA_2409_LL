using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationVille
{
    public class Ville : Capitalisable
    {
        private string nom { get; set; }
        private double population { get; set; }
        
        private Pays? pays;
        public Pays Pays { get => pays; set => pays = value; }

        private bool estCapitale;

      

        public void devenirCapitale()
        {
            estCapitale = true;
        }

        public void nePlusEtreCapitale()
        {
            estCapitale = false;
        }

        bool Capitalisable.estCapitale()
        {
            return estCapitale;
        }
    }
}
