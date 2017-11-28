using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface ILogger
    {
        void Handle(string error);
    }
}
