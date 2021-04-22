using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Fluent
{
    public interface IBlob
    {
        IAction OnBlob(string blobBlockPath);
    }
}
