using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public interface IBuyerRepository
    {
        Buyer GetById(int id);
    }
}
