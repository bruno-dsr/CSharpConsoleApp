using System;

namespace Exception_Project.Entities.Exceptions
{
    public class ContaException : ApplicationException
    {
        public ContaException(string message) : base(message)
        {
        }
    }
}
