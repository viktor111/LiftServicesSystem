namespace Support.Domain.Exceptions
{
    using Common.Domain;

    public class InvalidTicketException : BaseDomainException
    {
        public InvalidTicketException()
        {

        }

        public InvalidTicketException(string error)
        {
            this.Error = error;
        }
    }
}
