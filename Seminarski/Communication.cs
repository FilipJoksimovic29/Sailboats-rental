using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Seminarski
{
    public class Communication
    {

        private static Communication _instance;
        private Communication() { }

        public static Communication Instance {  
          get { 
           if (_instance == null) { _instance = new Communication(); }
                    
               return _instance; } }

        Socket socket;
        Sender s;
        Receiver receiver;
        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
          s = new Sender(socket);
            receiver = new Receiver(socket);

        }

        internal Response Login(User user)
        {
          Request req = new Request();
            req.Argument = user;
            req.Operacija = Operacija.Login;
            s.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
           
        }
        internal List<ClanPosade> UcitajClanovePosade()
        {
            Request request = new Request();
            request.Operacija = Operacija.UcitajClanovePosade;
            // request.Argument = clanPosade;
            s.Send(request);
            Response response = (Response)receiver.Receive();
            return response.Result as List<ClanPosade>;

        }

        internal List<Klijent> UcitajKlijente()
        {
            Request request = new Request();
            request.Operacija = Operacija.UcitajKlijente;
            s.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<Klijent>)response.Result;

        }

        internal List<Jedrilica> UcitajJedrilice()
        {
         Request request = new Request();
         request.Operacija = Operacija.UcitajJedrilice;
         s.Send(request);
         Response response = (Response)receiver.Receive();
         return (List<Jedrilica>)response.Result;
        }

        internal ClanPosade KreirajClanaPosade()
        {
            Request req = new Request();
            req.Operacija = Operacija.KreirajClanaPosade;
            s.Send(req);
            Response response = (Response)receiver.Receive();
            return response.Result as ClanPosade;
        }

        internal ClanPosade ZapamiClanaPosade(ClanPosade clanPosade)
        {
           Request request = new Request();
            request.Operacija = Operacija.ZapamtiClanaPosade;
            request.Argument = clanPosade;
            s.Send(request);
            Response response = (Response)receiver.Receive();
            return response.Result as ClanPosade;   

        }

        internal List<ClanPosade> NadjiClanaPosade() 
        {
            Request request = new Request();
            request.Operacija = Operacija.NadjiClanaPosade;
           // request.Argument = clanPosade;
            s.Send(request);
            Response response = (Response)receiver.Receive();
            return response.Result as List<ClanPosade>;

        }

        
        internal void ObrisiClanaPosade(ClanPosade cp)
        {
            Request request = new Request();
            request.Operacija = Operacija.ObrisiClanaPosade;
             request.Argument = cp;
            s.Send(request);
            Response response = (Response)receiver.Receive();
           
        }

        internal List<Klijent> PretragaKlijenata(string text)
        {
           Request request = new Request();
            request.Argument = text;
            request.Operacija = Operacija.NadjiKlijenta;
            s.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Klijent>)response.Result;
        }

        internal List<Jedrilica> PretragaJedrilica(string text)
        {
            Request request = new Request();
            request.Argument = text;
            request.Operacija = Operacija.NadjiJedrilicu;
            s.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<Jedrilica>)response.Result;
        }

        internal List<ClanPosade> UcitajListuClanovaPosade()
        {
            Request request = new Request();
            request.Operacija = Operacija.UcitajListuClanovaPosade;
            s.Send(request);
            Response response = (Response)receiver.Receive();
            return (List<ClanPosade>)response.Result;
        }

        internal List<ClanPosade> PretragaClanovaPosade(string text)
        {
            Request request = new Request();
            request.Argument = text;
            request.Operacija = Operacija.NadjiClanaPosade;
            s.Send(request);

            Response response = (Response)receiver.Receive();
            return (List<ClanPosade>)response.Result;
        }
    }
}
