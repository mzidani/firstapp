using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    public class Point
    {
        public double Abs { get; set; }
        public double Ord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="abs"></param>
        /// <param name="ord"></param>
        public Point(double abs, double ord)
        {
            this.Abs = abs;
            this.Ord = ord;
        }

        public override string ToString()
        {
            return String.Format("({0}.{1})", this.Abs, this.Ord);
        }

        public double CalculerDistance(Point p)
        {
            return Math.Round(Math.Sqrt(Math.Pow(p.Abs - this.Abs, 2) + Math.Pow(p.Ord - this.Ord, 2)), 2);
        }

        public Point CalculerMilieu(Point p)
        {
            double x = (this.Abs + p.Abs)/2.0;
            double y = (this.Ord + p.Ord)/2.0;
            return new Point(x, y);
        }

        public Point CalculerMilieuOp(Point p)
        {
            return (this+p)/2;
        }

        public static Point operator+ (Point p1, Point p2)
        {
            double x = p1.Abs + p2.Abs;
            double y = p1.Ord + p2.Ord;
            return new Point(x, y);
        }

        public static Point operator/ (Point p, double d)
        {
            double x = p.Abs / 2;
            double y = p.Ord / 2;
            return new Point(x, y);
        }
    }
}
