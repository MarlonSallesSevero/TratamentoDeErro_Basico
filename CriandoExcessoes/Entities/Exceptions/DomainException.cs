using System;

namespace CriandoExcessoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string mess0) : base(mess0){
        
        }
    }
}
