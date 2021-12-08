using Catalog.Domain.Models.Lifts;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Factories.Lifts
{
    public interface ILiftFactory : IFactory<Lift>
    {
        ILiftFactory WithName(string name);

        ILiftFactory WithDescription(string description);

        ILiftFactory WithPrice(decimal price);
    }
}
