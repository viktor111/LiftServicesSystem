﻿namespace Orders.Domain.Exceptions
{
    using Common.Domain;

    public class InvalidOrderException : BaseDomainException
    {
        public InvalidOrderException()
        {

        }

        public InvalidOrderException(string error)
        {
            this.Error = error;
        }
    }
}
