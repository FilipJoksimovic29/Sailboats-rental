using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Request
    {

        public object Argument { get; set; }

        public Operacija Operacija { get; set; }

    }
}
