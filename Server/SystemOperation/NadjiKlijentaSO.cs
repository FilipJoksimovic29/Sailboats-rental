using BrokerBaze;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation 
{
    internal class NadjiKlijentaSO : SystemOperationBase
    {
        public List<Klijent> Result { get; set; }
        string pretraga;
        public NadjiKlijentaSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.NadjiKlijenta(pretraga);
        }



    }
}
