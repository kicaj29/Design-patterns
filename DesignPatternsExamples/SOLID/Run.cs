using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public static class Run
    {
        public static void RunMe()
        {
            List<IDatabase> custs = new List<IDatabase>();
            custs.Add(new SilverCustomer());
            custs.Add(new GoldCustomer());
            //custs.Add(new Enquiry());

            foreach (var cust in custs)
            {
                cust.Add();
            }

            IDatabase i = new Customer(new EmailLogger());
        }
    }
}
