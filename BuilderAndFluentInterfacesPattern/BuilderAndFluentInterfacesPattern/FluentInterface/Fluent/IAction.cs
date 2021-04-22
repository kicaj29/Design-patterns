using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Fluent
{
    public interface IAction
    {
        IWrite Download(string fileName);
        IRead Upload(string fileName);
    }
}
