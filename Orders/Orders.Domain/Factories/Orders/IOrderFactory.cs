namespace Orders.Domain.Factories.Orders
{
    using Common.Domain;
    using Domain.Models.Orders;

    public interface IOrderFactory : IFactory<Order>
    {
        IOrderFactory WithUser(string userId);

        IOrderFactory WithLift(int liftId);

        IOrderFactory WithPrice(decimal price);

        IOrderFactory WithAddress(string country, string city, string street);

        IOrderFactory WithAddress(Address address);

        IOrderFactory WithPhoneNumber(string countryCode, string number);

        IOrderFactory WithPhoneNumber(PhoneNumber phoneNumber);
    }
}
