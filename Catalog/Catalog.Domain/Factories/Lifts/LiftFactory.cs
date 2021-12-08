namespace Catalog.Domain.Factories.Lifts
{
    using Domain.Exceptions;
    using Domain.Models.Lifts;

    public class LiftFactory : ILiftFactory
    {
        private string name = default!;
        private string description = default!;
        private decimal price = default!;

        private bool isNameSet = false;
        private bool isDescriptionSet = false;
        private bool isPriceSet = false;

        public ILiftFactory WithName(string name)
        {
            this.name = name;
            this.isNameSet = true;
            return this;
        }

        public ILiftFactory WithDescription(string description)
        {
            this.description = description;
            this.isDescriptionSet = true;
            return this;
        }

        public ILiftFactory WithPrice(decimal price)
        {
            this.price = price;
            this.isPriceSet = true;
            return this;
        }

        public Lift Build()
        {
            if (!this.isNameSet ||
                !this.isDescriptionSet ||
                !this.isPriceSet)
            {
                throw new InvalidLiftException("Lift must have Name, Description, Price set to be valid.");
            }

            return new Lift(
                this.name,
                this.description,
                this.price, true);
        }

    }
}
