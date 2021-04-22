using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public static class FluentBuilderPatternUsage
    {
        public static void Use()
        {
            IBuyerRepository buyerRepository = new BuyerRepository();
            ISellerRepository sellerRepository = new SellerRepository();
            IProductRepository productRepository = new ProductRepository();

            // use without builder:

            Buyer buyer = buyerRepository.GetById(1);
            Seller seller = sellerRepository.GetById(2);
            Product product = productRepository.GetById(3);
            Order order = new Order(buyer, seller, product, 4);

            // use with the builder static init:

            Order o = OrderBuilder.Init(buyerRepository, sellerRepository, productRepository)
                          .SetBuyer(1)
                          .SetSeller(2)
                          .SetProduct(3)
                          .Build();

            // use with the builder public constructor

            OrderBuilder orderBuilder = new OrderBuilder(buyerRepository, sellerRepository, productRepository);

            Order o1 = orderBuilder
                        .SetBuyer(1)
                        .SetSeller(2)
                        .SetProduct(3)
                        .Build();

        }
    }
}
