using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
