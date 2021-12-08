namespace Catalog.Domain.Models.Lifts
{
    using Catalog.Domain.Exceptions;
    using Common.Domain;
    using Common.Domain.Models;

    using static ModelConstants.Lift;

    public class Lift : Entity<int>, IAggregateRoot
    {
        internal Lift(
            string name,
            string description,
            decimal price,
            bool isAvalable)
        {
            this.Validate(
                name,
                description,
                price);

            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.IsAvailable = isAvalable;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public bool IsAvailable { get; private set; }


        public Lift UpdateName(string name)
        {
            this.ValidateName(name);
            this.Name = name;
            return this;
        }

        public Lift UpdateDescription(string description)
        {
            this.ValidateDescription(description);
            this.Description = description;
            return this;
        }

        public Lift UpdatePrice(decimal price)
        {
            this.ValidatePrice(price);
            this.Price = price;
            return this;
        }

        public Lift ChangeAvailability()
        {
            this.IsAvailable = !this.IsAvailable;
            return this;
        }

        private void Validate(string name, string description, decimal price)
        {
            this.ValidateName(name);
            this.ValidateDescription(description);
            this.ValidatePrice(price);
        }

        private void ValidateName(string name)
        {
            Guard.AgainstEmptyString<InvalidLiftException>(
                name,
                nameof(this.Name));

            Guard.ForStringLength<InvalidLiftException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
        }


        private void ValidateDescription(string description)
        {
            Guard.AgainstEmptyString<InvalidLiftException>(
                description,
                nameof(this.Description));

            Guard.ForStringLength<InvalidLiftException>(
                description,
                MinDescriptionLength,
                MaxDescriptionLength,
                nameof(this.Description));
        }

        private void ValidatePrice(decimal price)
        {
            Guard.AgainstOutOfRange<InvalidLiftException>(
                price,
                MinPrice,
                MaxPrice,
                nameof(this.Price));
        }
    }
}
