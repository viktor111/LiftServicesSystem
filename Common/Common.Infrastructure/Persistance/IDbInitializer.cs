using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Infrastructure.Persistance
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
