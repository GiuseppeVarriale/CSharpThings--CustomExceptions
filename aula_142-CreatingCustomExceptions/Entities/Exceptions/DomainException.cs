using System;

namespace aula_142_CreatingCustomExceptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) 
        {
        }
    }
}
