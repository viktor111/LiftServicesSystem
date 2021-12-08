namespace Orders.Domain.Exceptions
{
    using Common.Domain;

    public class InvalidPhoneNumberException : BaseDomainException
    {

        public InvalidPhoneNumberException()
        {

        }

        public InvalidPhoneNumberException(string error)
        {
            this.Error = error;
        }
    }
}
