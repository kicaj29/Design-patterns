using BuilderAndFluentInterfacesPattern.Builder;
using BuilderAndFluentInterfacesPattern.FluentBuilderPattern;
using BuilderAndFluentInterfacesPattern.FluentInterface;
using System;

namespace BuilderAndFluentInterfacesPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentBuilderPatternUsage.Use();

            FluentInterfacePatternUsage.GoAsync();

            BuilderUse.Go();

            Console.WriteLine("Hello World!");
        }
    }
}
