using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class CustomerwithRead : IDatabase, IDatabaseV1
    {
        public void Add()
        {
            ILogger logger = new EmailLogger();
            Customer obj = new Customer(logger);
            obj.Add();
        }

        public void Read()
        {
            // Implements  logic for read
        }
    }
}
