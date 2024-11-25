using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;

        public ClientHandler (Socket socket)
        {
            sender = new Sender (socket);
            receiver = new Receiver (socket);   

        }


        public void HandleRequest()
        {
            while(true) {
           Request req = (Request)receiver.Receive();
           Response res = ProcessRequest(req);
           sender.Send (res);
              }
            

        }

        private Response ProcessRequest(Request req)
        {
            Response res = new Response();
            switch (req.Operacija)
            {
                case Operacija.Login:
                   res.Result = Controller.Instance.Login((User)req.Argument);
                    break; 
                
                case Operacija.UcitajKlijente:
                    res.Result = (List<Klijent>)Controller.Instance.UcitajKlijente();
                    break;
                case Operacija.UcitajJedrilice:
                    res.Result = (List<Jedrilica>)Controller.Instance.UcitajJedrilice();
                    break;
                case Operacija.NadjiKlijenta:
                    res.Result = Controller.Instance.NadjiKlijenta((string)req.Argument);
                    break;
                case Operacija.NadjiJedrilicu:
                    res.Result = Controller.Instance.NadjiJedrilicu((string)req.Argument);
                    break;
                case Operacija.KreirajClanaPosade:
                    res.Result = Controller.Instance.KreirajClanaPosade();
                    break;

                case Operacija.ZapamtiClanaPosade:
                    res.Result = Controller.Instance.ZapamiClanaPosade((ClanPosade)req.Argument);
                    break;

               

                case Operacija.NadjiClanaPosade:
                    res.Result = Controller.Instance.NadjiClanaPosade((string)req.Argument);
                    break;

                case Operacija.ObrisiClanaPosade:
                    res.Result = Controller.Instance.ObrisiClanaPosade((ClanPosade)req.Argument);
                    break;

                case Operacija.ZapamtiJedrilicu:
                    // Logika za ZapamtiJedrilicu
                    break;

                

                case Operacija.ObrisiJedrilicu:
                    // Logika za ObrisiJedrilicu
                    break;

                case Operacija.ZapamtiKlijenta:
                    // Logika za ZapamtiKlijenta
                    break;

                

                case Operacija.UcitajKlijenta:
                    // Logika za UcitajKlijenta
                    break;

                case Operacija.ObrisiKlijenta:
                    // Logika za ObrisiKlijenta
                    break;

                case Operacija.UcitajListuKlijenata:
                    // Logika za UcitajListuKlijenata
                    break;

                case Operacija.UcitajListuClanovaPosade:
                    res.Result = (List<ClanPosade>)Controller.Instance.UcitajListuClanovaPosade();
                    break;

                case Operacija.UcitajListuJedrilica:
                    // Logika za UcitajListuJedrilica
                    break;

                case Operacija.KreirajDokument:
                    // Logika za KreirajDokument
                    break;

                case Operacija.ZapamtiDokument:
                    // Logika za ZapamtiDokument
                    break;

                case Operacija.NadjiDokumentOIznajmljenoj:
                    // Logika za NadjiDokumentOIznajmljenoj
                    break;

                default:
                    // Ako nije pronađen odgovarajući slučaj
                    break;
            }
            return res;
        }

    }
}
