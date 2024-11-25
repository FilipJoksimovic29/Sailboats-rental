using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class DokumentOIznajmljenojJedrilici
    {
        public int brojUgovoraID{get; set;}
        public DateTime datumIzdavanja { get; set; }
        public DateTime datumVracanja{ get; set; }
        public Jedrilica jedrilica { get; set; }
        public Klijent klijent { get; set; }

        public override string ToString()
        {
            return $" BrojUgovoraID:{brojUgovoraID}   DatumIzdavanja:{datumIzdavanja} " +
                $"  DatumVracanja:{datumVracanja}   Jedrilica:{jedrilica.regID}   Klijent:{klijent.jmbgID}";
        }

    }
}
