using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentBuilderPattern
{
    public class OrderBuilder
    {
        private Order _order = new Order();
        private readonly IBuyerRepository _buyerRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IProductRepository _producteRepository;

        public OrderBuilder(
                         IBuyerRepository buyerRepository,
                         ISellerRepository sellerRepository,
                         IProductRepository producteRepository)
        {
            _buyerRepository = buyerRepository;
            _sellerRepository = sellerRepository;
            _producteRepository = producteRepository;
        }
        public static OrderBuilder Init(
                                   IBuyerRepository buyerRepository,
                                   ISellerRepository sellerRepository,
                                   IProductRepository producteRepository)
        {
            return new OrderBuilder(buyerRepository, sellerRepository, producteRepository);
        }
        public Order Build() => _order;
        public OrderBuilder SetBuyer(int buyerId)
        {
            _order.Buyer = _buyerRepository.GetById(buyerId);
            return this;
        }
        public OrderBuilder SetSeller(int sellerId)
        {
            _order.Seller = _sellerRepository.GetById(sellerId);
            return this;
        }

        public OrderBuilder SetProduct(int sellerId)
        {
            _order.Product = _producteRepository.GetById(sellerId);
            return this;
        }
    }
}
