using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class Customer : IDiscount, IDatabase
    {
        private ILogger _logger;
        public Customer(ILogger logger)
        {
            this._logger = logger;
        }

        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                this._logger.Handle(ex.ToString());
            }
            //For some people who are seniors looking at above SRP example can contradict
            //that even the try catch should not be handled by the customer class because that is not his work.
        }

        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
