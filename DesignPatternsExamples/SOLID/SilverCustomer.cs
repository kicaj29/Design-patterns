using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class SilverCustomer : Customer
    {

        public SilverCustomer() : base(new FileLogger())
        {
            
        }

        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }
    }
}
