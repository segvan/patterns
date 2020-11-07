using System;

namespace patterns.library.Factory
{
    public class Point
    {
        // factory methods
        public static Point FactoryMethodCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point FactoryMethodPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}