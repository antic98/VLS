using System;

namespace UserInterface.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException(string message) : base(message)
        {
        }
    }
}
