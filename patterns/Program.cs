using patterns.library.Builder;
using patterns.library.Factory;
using static System.Console;

namespace patterns
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BuilderDemo();
            FactoryDemo();
        }

        private static void FactoryDemo()
        {
            // Factory method
            var cartesianPoint = Point.FactoryMethodCartesianPoint(1, 1);
            var polarPoint = Point.FactoryMethodPolarPoint(1, 1);
            
            // Factory
            var cartesianPoint2 = PointFactory.NewCartesianPoint(1, 1);
            var polarPoint2 = PointFactory.NewPolarPoint(1, 1);
            
            // Inner Factory
            var cartesianPoint3 = Point3.Factory.NewCartesianPoint(1, 1);
            var polarPoint3 = Point3.Factory.NewPolarPoint(1, 1);
            
            // Abstract Factory
            var cartesianPoint4 = AbstractPointFactory.NewPoint(1, 1, PointType.Cartesian);
            var polarPoint4 = AbstractPointFactory.NewPoint(1, 1, PointType.Polar);
        }

        private static void BuilderDemo()
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