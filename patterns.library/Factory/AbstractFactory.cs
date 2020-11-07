using System;

namespace patterns.library.Factory
{
    public enum PointType
    {
        Cartesian,
        Polar
    }

    public interface IPoint
    {
        public double X { get; }
        public double Y { get; }
    }

    public class Point4 : IPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        internal Point4(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public static class AbstractPointFactory
    {
        public static IPoint NewPoint(double a, double b, PointType type)
        {
            switch (type)
            {
                case PointType.Cartesian:
                    return new Point4(a, b);
                case PointType.Polar:
                    return new Point4(a * Math.Cos(b), a * Math.Sin(b));
                default:
                    throw new NotSupportedException();
            }
        }
    }
}