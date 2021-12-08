using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Models
{
    public class ModelConstants
    {
        public class Lift
        {
            public const int MinNameLength = 3;
            public const int MaxNameLength = 100;
            public const int MinDescriptionLength = 3;
            public const int MaxDescriptionLength = 1000;
            public const decimal MinPrice = 1;
            public const decimal MaxPrice = 1000000;
        }
    }
}
