using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edito
{
    internal class Journal
    {
        public int IdJournal { get; set; }
        public string Titre { get; set; }
        public DateTime? DtParution { get; set; }
    }
}
