namespace Orders.Domain.Exceptions
{
    using Common.Domain;

    public class InvalidAddressException : BaseDomainException
    {
        public InvalidAddressException()
        {

        }

        public InvalidAddressException(string error)
        {
            this.Error = error;
        }
    }
}
