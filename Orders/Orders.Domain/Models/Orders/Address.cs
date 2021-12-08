namespace Orders.Domain.Models.Orders
{
    using Common.Domain.Models;
    using Exceptions;

    using static ModelConstnats.Address;

    public class Address : ValueObject
    {
        internal Address(
            string country,
            string city,
            string street)
        {
            this.Validate(country, city, street);
            this.Country = country;
            this.City = city;
            this.Street = street;
        }

        public string Country { get; private set; }

        public string City { get; private set; }

        public string Street { get; private set; }

        public void UpdateCountry(string country)
        {
            ValidateCountry(country);
            this.Country = country;
        }

        public void UpdateCity(string city)
        {
            ValidateCity(city);
            this.City = city;
        }

        public void UpdateStreet(string street)
        {
            ValidateStreet(street);
            this.Street = street;
        }

        private void Validate(string country, string city, string street)
        {
            ValidateCountry(country);
            ValidateCity(city);
            ValidateStreet(street);
        }

        private void ValidateCountry(string country)
        {
            Guard.AgainstEmptyString<InvalidAddressException>(country, nameof(country));
            Guard.ForStringLength<InvalidAddressException>(country,
                MinCountryLength,
                MaxCountryLength,
                nameof(country));
        }

        private void ValidateCity(string city)
        {
            Guard.AgainstEmptyString<InvalidAddressException>(city, nameof(city));
            Guard.ForStringLength<InvalidAddressException>(city,
                MinCityLength,
                MaxCityLength,
                nameof(city));
        }

        private void ValidateStreet(string street)
        {
            Guard.AgainstEmptyString<InvalidAddressException>(street, nameof(street));
            Guard.ForStringLength<InvalidAddressException>(street,
                MinStreetLength,
                MaxStreetLength,
                nameof(street));
        }
    }
}
