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
        private static Communication instance;
        public static Communication Instance
        {
            get 
            { 
                if (instance == null) instance = new Communication();
                return instance; 
            }
        }
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
                Request request = new Request
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

        public object GetResult()
        {
            Response response = helper.Receive<Response>();

            if (response.IsSuccesful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Message);
            }
        }
                
        public void Login(User user)
        {
            SendRequest(Operation.Login, user);
            
            Session.SessionData.Instance.User = (User)GetResult();
        } 
        public void Close()
        {
            if (socket == null) return;
            
            SendRequest(Operation.Kraj);

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
            Response response = helper.Receive<Response>();

            return response.IsSuccesful;
        }
    }
}
