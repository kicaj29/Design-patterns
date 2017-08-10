using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientContextExamples.Example1
{
    public interface ICredentials
    {
        string User { get; set; }
        string Password { get; set; }
    }
}
