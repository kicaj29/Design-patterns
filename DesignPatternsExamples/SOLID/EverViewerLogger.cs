using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }
}
