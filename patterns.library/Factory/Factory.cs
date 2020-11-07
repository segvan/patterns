using System;

namespace patterns.library.Factory
{
    public class PointFactory
    {
        public static Point2 NewCartesianPoint(double x, double y)
        {
            return new Point2(x, y);
        }

        public static Point2 NewPolarPoint(double rho, double theta)
        {
            return new Point2(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
    
    public class Point2
    {
        private double x, y;

        internal Point2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}