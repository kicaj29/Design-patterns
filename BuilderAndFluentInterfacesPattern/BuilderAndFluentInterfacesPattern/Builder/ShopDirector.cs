using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    /// <summary>
    /// ShopDirector also does not know details of building the shop.
    /// </summary>
    public class ShopDirector
    {
        private IShopBuilder shopbuilder;

        public ShopDirector(IShopBuilder shopbuilder)
        {
            this.shopbuilder = shopbuilder;
        }

        public void buildShop()
        {
            shopbuilder.BuildFloor();
            shopbuilder.BuildRoof();
            shopbuilder.BuildWall();
        }

        public Shop getShop()
        {
            return shopbuilder.getShop();
        }
    }
}
