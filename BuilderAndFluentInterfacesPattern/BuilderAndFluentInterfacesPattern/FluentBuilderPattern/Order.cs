using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public class Order
    {
        public Buyer Buyer { get; set; }
        public Seller Seller { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }

        public Order()
        {

        }

        public Order(Buyer buyer, Seller seller, Product product, double price)
        {
            this.Buyer = buyer;
            this.Seller = seller;
            this.Product = product;
            this.Price = price;
        }
    }
}
