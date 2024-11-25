using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Receiver
    {

        private NetworkStream stream;
        private BinaryFormatter formatter;


        public Receiver(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();

        }

        public object Receive()
        {
          return  formatter.Deserialize(stream);
        }


    }
}
