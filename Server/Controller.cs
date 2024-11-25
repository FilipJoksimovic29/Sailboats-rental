using System;
using System.Collections.Generic;
using BrokerBaze;
using Common.Domain;
using Server.SystemOperation;

namespace Server
{
    public class Controller
    {
        private Broker broker;
        private static Controller instance;
        private Controller() { broker = new Broker(); }

        public static Controller Instance { 
            get { if (instance == null) { instance = new Controller(); } 
                return instance; } }

        public User Login(User user)
        {
            User u;
          broker.OpenConnection();
          u= broker.Login(user);
          broker.CloseConnection();
            return u;

        }

        public ClanPosade KreirajClanaPosade()
        {
            ClanPosade cp;
            broker.OpenConnection();
          cp = broker.KreirajClanaPosade();
            broker.CloseConnection();
            return cp;
        }

        public ClanPosade ZapamiClanaPosade(ClanPosade argument)
        {
            ClanPosade cp;
            broker.OpenConnection();
          cp =  broker.ZapamiClanaPosade(argument);
            broker.CloseConnection();
            return cp;
        }

      

        internal Boolean ObrisiClanaPosade(ClanPosade argument)
        {
            broker.OpenConnection();
            broker.ObrisiClanaPosade(argument);
            broker.CloseConnection();
            return true;
        }

        

        internal List<Klijent> UcitajKlijente()
        {
            try
            {
                broker.OpenConnection();
                return broker.UcitajKlijente();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        internal List<Jedrilica> UcitajJedrilice()
        {
            try
            {
                broker.OpenConnection();
                return broker.UcitajJedrilice();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

         internal List<ClanPosade> NadjiClanaPosade(string argument)
        {
            NadjiClanaPosadeSO pretragaclanovaposade = new NadjiClanaPosadeSO(argument);
            pretragaclanovaposade.ExecuteTemplate();
            return pretragaclanovaposade.Result;
        }

        internal List<Klijent> NadjiKlijenta(string argument)
        {
            NadjiKlijentaSO pretragaklijenata = new NadjiKlijentaSO(argument);
            pretragaklijenata.ExecuteTemplate();
            return pretragaklijenata.Result;
        }

        internal object NadjiJedrilicu(string argument)
        {
            NadjiJedrilicuSO pretragajedrilica = new NadjiJedrilicuSO(argument);
            pretragajedrilica.ExecuteTemplate();
            return pretragajedrilica.Result;
        }

        internal List<ClanPosade> UcitajListuClanovaPosade()
        {
            UcitajListuClanovaPosadeSO listaclanovaposade = new UcitajListuClanovaPosadeSO();
            listaclanovaposade.ExecuteTemplate();
            return listaclanovaposade.Result;
        }
    }
}
