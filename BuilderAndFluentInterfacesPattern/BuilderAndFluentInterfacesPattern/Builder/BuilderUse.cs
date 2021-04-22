using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public static class BuilderUse
    {
        public static void Go()
        {
            IShopBuilder shopbuilder = new BigShopTesco();

            ShopDirector shopdirector = new ShopDirector(shopbuilder);
            // just call buildShop without knowing how the shop will be build!
            shopdirector.buildShop();
        }
    }
}
