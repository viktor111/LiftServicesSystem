using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.Models
{
    public class ModelConstnats
    {
        public class PhoneNumber
        {
            public const int MinCountryCodeLength = 1;
            public const int MaxCountryCodeLength = 10;
            public const int MinPhoneNumberLength = 5;
            public const int MaxPhoneNumberLength = 20;
            public const string CountryCodeRegularExpression = @"\+[0-9]*";
        }

        public class Address
        {
            public const int MinCountryLength = 2;
            public const int MaxCountryLength = 50;
            public const int MinCityLength = 2;
            public const int MaxCityLength = 50;
            public const int MinStreetLength = 2;
            public const int MaxStreetLength = 100;
        }

        public class Order
        {
            public const decimal MinPrice = 1;
            public const decimal MaxPrice = 1000000;
        }
    }
}
