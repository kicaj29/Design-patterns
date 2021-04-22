using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFluentInterfacesPattern.FluentInterface.Fluent
{
    public interface IWrite
    {
        void ToFile(string filePath);
        Task ToFileAsync(string filePath);
        void ToStream(Stream stream);
        Task ToStreamAsync(Stream stream);
    }
}
