using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public class SellerRepository : ISellerRepository
    {
        public Seller GetById(int id)
        {
            return new Seller();
        }
    }
}
