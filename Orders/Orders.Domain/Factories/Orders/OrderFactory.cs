namespace Orders.Domain.Factories.Orders
{
    using Domain.Exceptions;
    using Domain.Models.Orders;

    public class OrderFactory : IOrderFactory
    {
        private string userId = default!;
        private int liftId = default!;
        private decimal price = default!;
        private Address address = default!;
        private PhoneNumber phoneNumber = default!;

        private bool isUserIdSet = false;
        private bool isLiftIdSet = false;
        private bool isPriceSet = false;
        private bool isAddressSet = false;
        private bool isPhoneNumberSet = false;


        public IOrderFactory WithUser(string userId)
        {
            this.userId = userId;
            this.isUserIdSet = true;
            return this;
        }

        public IOrderFactory WithLift(int liftId)
        {
            this.liftId = liftId;
            this.isLiftIdSet = true;
            return this;
        }

        public IOrderFactory WithPrice(decimal price)
        {
            this.price = price;
            this.isPriceSet = true;
            return this;
        }

        public IOrderFactory WithAddress(string country, string city, string street)
        {
            this.address = new Address(country, city, street);
            this.isAddressSet = true;
            return this;
        }

        public IOrderFactory WithAddress(Address address)
        {
            this.address = address;
            this.isAddressSet = true;
            return this;
        }

        public IOrderFactory WithPhoneNumber(string countryCode, string number)
        {
            this.phoneNumber = new PhoneNumber(countryCode, number);
            this.isPhoneNumberSet = true;
            return this;
        }

        public IOrderFactory WithPhoneNumber(PhoneNumber phoneNumber)
        {
            this.phoneNumber= phoneNumber;
            this.isPhoneNumberSet = true;
            return this;
        }
       
        public Order Build()
        {
            if(!isUserIdSet || !isLiftIdSet || !isPriceSet || !isAddressSet || !isPhoneNumberSet)
            {
                throw new InvalidOrderException("Not all fields are set");
            }

            return new Order(
                userId,
                liftId,
                price,
                address,
                phoneNumber);
        }
    }
}
