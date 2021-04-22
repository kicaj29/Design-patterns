using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.Builder
{
    public class Shop
    {
        private IRoof roof;

        private IFloor floor;

        private IWall wall;

        public void SetRoof(IRoof roof)
        {
            this.roof = roof;
        }

        public IRoof GetRoof()
        {
            return roof;
        }

        public void SetFloor(IFloor floor)
        {
            this.floor = floor;
        }

        public IFloor GetFloor()
        {
            return floor;
        }

        public void SetWall(IWall wall)
        {
            this.wall = wall;
        }

        public IWall GetWall()
        {
            return wall;
        }
    }
}
