using patterns.library.Builder;
using static System.Console;

namespace patterns
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BuilderDemo();
        }
        
        static void BuilderDemo()
        {
            // ordinary non-fluent builder
            var builder = new Builder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            var htmlElement = builder.Build();
            WriteLine(htmlElement);

            // fluent builder
            htmlElement = new FluentBuilder("ul")
                .AddChildFluent("li", "hello")
                .AddChildFluent("li", "world")
                .Build();
            WriteLine(htmlElement);
            
            // functional builder
            var person = new FunctionalBuilder()
                .Called("Sergii")
                .WorksAsA("Programmer")
                .Build();
            WriteLine(person);
        }
    }
}