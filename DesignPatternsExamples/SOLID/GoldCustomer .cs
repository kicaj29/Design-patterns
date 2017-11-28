using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class GoldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }
}
