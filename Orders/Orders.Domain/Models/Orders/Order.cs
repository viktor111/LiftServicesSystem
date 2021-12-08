namespace Orders.Domain.Models.Orders
{
    using Common.Domain;
    using Common.Domain.Models;
    using Exceptions;

    using static ModelConstnats.Order;

    public class Order : Entity<int>, IAggregateRoot
    {
        internal Order(
            string userId,
            int liftId,
            decimal price,
            Address address,
            PhoneNumber phoneNumber)
        {
            this.Validate(price);

            this.UserId = userId;
            this.LiftId = liftId;
            this.Price = price;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string UserId { get; private set; }

        public int LiftId { get; private set; }

        public decimal Price { get; private set; }

        public Address Address { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        public Order UpdateUser(string userId)
        {
            this.ValidateUserId(userId);
            this.UserId = userId;
            return this;
        }

        public Order UpdateLift(int liftId)
        {
            this.LiftId = liftId;
            return this;
        }

        public Order UpdatePrice(decimal price)
        {
            this.ValidatePrice(price);
            this.Price = price;
            return this;
        }

        public Order UpdateAddress(
            string country,
            string city,
            string street)
        {
            this.Address = new Address(country, city, street);
            return this;
        }

        public Order UpdateAdress(Address address)
        {
            this.Address = address;
            return this;
        }

        public Order UpdatePhoneNumber(string countryCode, string number)
        {
            this.PhoneNumber = new PhoneNumber(countryCode, number);
            return this;
        }

        public Order UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
            return this;
        }

        private void Validate(decimal price)
        {
            this.ValidatePrice(price);
        }

        private void ValidateUserId(string userId)
        {
            Guard.AgainstEmptyString<InvalidOrderException>(
                userId, 
                nameof(this.UserId));
        }

        private void ValidatePrice(decimal price)
        {
            Guard.AgainstOutOfRange<InvalidOrderException>(
                price,
                MinPrice,
                MaxPrice,
                nameof(this.Price));
        }
    }
}
