using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Enquiry : IDiscount
    {
        public double getDiscount(double TotalSales)
        {
            return TotalSales - 5;
        }
    }
}
