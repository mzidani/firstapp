using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(3, 3);
            TroisPoints tp = new TroisPoints(p1, p2, p3);
            Console.WriteLine(p1.CalculerDistance(p2));
            Console.WriteLine(p2.CalculerDistance(p3));
            Console.WriteLine(p2.CalculerMilieu(p3));
            Console.WriteLine(tp.TesterAlignement());
            Console.WriteLine(tp.EstIsocele());
        }
    }
}
