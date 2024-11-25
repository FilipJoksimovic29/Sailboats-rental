using BrokerBaze;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class NadjiClanaPosadeSO : SystemOperationBase
    {

        public List<ClanPosade> Result { get; set; }
        string pretraga;
        public NadjiClanaPosadeSO(string pretraga)
        {
            this.pretraga = pretraga;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.NadjiClanaPosade(pretraga);
        }



    }
}
