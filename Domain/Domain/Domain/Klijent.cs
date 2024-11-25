using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Klijent
    {
        public int jmbgID { get; set; }
        public string imeprezime { get; set; }
        public DateTime datumRodj { get; set; }
       public string mestoStanovanja{get; set;}
        public string iskustvo { get; set; }

        public override string ToString()
        {
            return $" JMBG:{jmbgID}   Ime i Prezime:{imeprezime}   Datum Rodjenja:{datumRodj}   Mesto Rodjenja:{mestoStanovanja}   Iskustvo:{iskustvo} ";
        }

    }
}
