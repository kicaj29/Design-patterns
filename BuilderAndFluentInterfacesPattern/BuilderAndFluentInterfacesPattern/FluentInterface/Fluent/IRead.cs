using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Fluent
{
    public interface IRead
    {
        void FromFile(string filePath);
        Task FromFileAsync(string filePath);
        void FromStream(Stream stream);
        Task FromStreamAsync(Stream stream);
    }
}
