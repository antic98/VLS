using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    public class CommunicationHelper
    {
        private Socket socket;
        private readonly NetworkStream stream;
        private readonly BinaryFormatter formatter;

        public CommunicationHelper(Socket socket)
        {
            this.socket = socket;
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send<T>(T obj) where T : class
        {                           
            formatter.Serialize(stream, obj);    
        }

        public T Receive<T>() where T : class
        {
            return (T)formatter.Deserialize(stream);
        }
    }
}
