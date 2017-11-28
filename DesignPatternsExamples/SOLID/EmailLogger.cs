using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class EmailLogger : ILogger
    {

        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
