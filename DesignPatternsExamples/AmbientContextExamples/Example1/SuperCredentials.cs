using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using AmbientContextExamples.Example1;

namespace AmbientContextExamples.Example1
{
    public class SuperCredentials : ICredentials
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
