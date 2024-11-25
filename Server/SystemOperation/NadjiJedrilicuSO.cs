using BrokerBaze;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class NadjiJedrilicuSO : SystemOperationBase
    {

        public List<Jedrilica> Result { get; set; }
        string pretraga;
        public NadjiJedrilicuSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.NadjiJedrilicu(pretraga);
        }



    }
}
