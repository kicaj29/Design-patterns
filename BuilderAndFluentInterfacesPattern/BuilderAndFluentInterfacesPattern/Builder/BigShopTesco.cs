using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    /// <summary>
    /// Here is all logic needed to build big Tesco shop.
    /// </summary>
    public class BigShopTesco : IShopBuilder
    {
        private Shop shop;

        public BigShopTesco()
        {
            this.shop = new Shop();
        }

        public void BuildFloor()
        {
            IFloor floor = new Floor();

            floor.SetLenght(20);
            floor.SetNumberOfTiles(100);
            floor.SetTypeGreatnessTiles("Big");

            shop.SetFloor(floor);
        }

        public void BuildRoof()
        {
            IRoof roof = new Roof();

            roof.SetHeight(10);

            shop.SetRoof(roof);
        }

        public void BuildWall()
        {
            IWall wall = new Wall();

            wall.SetThickness(1);
            wall.SetColor("Green");

            shop.SetWall(wall);
        }

        public Shop getShop()
        {
            return shop;
        }
    }
}
