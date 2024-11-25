using BrokerBaze;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UcitajListuClanovaPosadeSO : SystemOperationBase
    {

        public List<ClanPosade> Result { get; set; }
       
        public UcitajListuClanovaPosadeSO()
        {
           
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.UcitajListuClanovaPosade();
        }



    }
}
