using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Sender
    {
        private NetworkStream stream;
        private BinaryFormatter formatter;


        public Sender(Socket socket) {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        
        }

        public void Send(object agr)
        {
           formatter.Serialize(stream, agr);
        }

    }
}
