using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    interface IDatabaseV1 : IDatabase // Gets the Add method
    {
        void Read();
    }
}
