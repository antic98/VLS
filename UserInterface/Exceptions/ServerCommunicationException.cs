using System;

namespace UserInterface.Exceptions
{
    public class ServerCommunicationException : Exception
    {
        public ServerCommunicationException(string message) : base(message)
        {
        }
    }
}
