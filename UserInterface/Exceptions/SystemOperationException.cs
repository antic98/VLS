using System;

namespace UserInterface.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException()
        {

        }
        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
