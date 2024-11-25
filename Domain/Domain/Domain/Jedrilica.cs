using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Jedrilica
    {

        public string regID { get; set; } 

        public string model { get; set; }

        public string tip { get; set; }

        public override string ToString()
        {
            return $" Registracija:{regID}  Model:{model}  Tip:{tip}";
        }


    }
}
