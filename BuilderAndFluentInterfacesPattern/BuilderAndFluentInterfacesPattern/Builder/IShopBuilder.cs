using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public interface IShopBuilder
    {
        void BuildFloor();
        void BuildRoof();
        void BuildWall();
        Shop getShop();
    }
}
