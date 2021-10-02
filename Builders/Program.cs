using System;
using Builders.Models;

namespace Builders
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryFluentMethod();

            Console.ReadKey();
        }

        static void FactoryFluentMethod()
        {
            Console.WriteLine(nameof(FactoryFluentMethod));

            var builder = HtmlElement.Create("ul")
                 .AddChild("li", "hello")
                 .AddChild("li", "world");               

            Console.WriteLine(builder);
        }

    }
}
