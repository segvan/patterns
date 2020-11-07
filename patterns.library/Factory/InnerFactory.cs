using System;

namespace patterns.library.Factory
{
    public class Point3
    {
        private double x, y;

        private Point3(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public static class Factory
        {
            public static Point3 NewCartesianPoint(double x, double y)
            {
                return new Point3(x, y);
            }

            public static Point3 NewPolarPoint(double rho, double theta)
            {
                return new Point3(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
}