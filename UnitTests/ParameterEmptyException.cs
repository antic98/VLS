using System;

namespace UnitTests
{
    internal class ParameterEmptyException : Exception
    {

        public ParameterEmptyException(string message)
        : base(message)
        {
        }
    }
}