namespace Catalog.Domain.Exceptions
{
    using Common.Domain;

    public class InvalidLiftException : BaseDomainException
    {
        public InvalidLiftException()
        {

        }

        public InvalidLiftException(string error)
        {
            this.Error = error;
        }
    }
}
