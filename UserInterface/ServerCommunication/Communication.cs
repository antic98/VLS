using Common;
using Domain;
using System.IO;
using System.Net.Sockets;
using UserInterface.Exceptions;

namespace UserInterface.ServerCommunication
{
    public class Communication
    {
        private Socket socket;

        private CommunicationHelper helper;
        private static Communication _instance;
        public static Communication Instance => _instance ?? (_instance = new Communication());
        private Communication() { }

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            helper = new CommunicationHelper(socket);
        }
              
        private void SendRequest(Operation operation, object requestObject = null)
        {
            try
            {
                var request = new Request
                {
                    Operation = operation,
                    RequestObject = requestObject
                };
                helper.Send(request);
            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }

        private object GetResult()
        {
            var response = helper.Receive<Response>();

            if (response.IsSuccesful)
            {
                return response.Result;
            }

            throw new SystemOperationException(response.Message);
        }
                
        public void Login(User user)
        {
            SendRequest(Operation.Login, user);
            
            Session.SessionData.Instance.User = (User)GetResult();
        }
        
        public void Close()
        {
            if (socket == null) return;
            
            SendRequest(Operation.End);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();

            socket = null;
        }
        

        public object GetList(Operation operation)
        {
            SendRequest(operation);

            return GetResult();
        }

        public object Search(Operation operation, object obj)
        {            
            SendRequest(operation, obj);
            
            return GetResult();
        }

        public bool SaveDeleteUpdate(Operation operation, object obj)
        {
            SendRequest(operation, obj);
            var response = helper.Receive<Response>();

            return response.IsSuccesful;
        }
    }
}
