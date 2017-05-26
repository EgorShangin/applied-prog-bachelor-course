using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Line
    {
        public Point a;
        public Point b;
        public void init()
        {

            Console.WriteLine("Coordinates of the first point: ");

            Console.Write("x=");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y=");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coordinates of the second point:");

            Console.Write("x=");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y=");
            double y2 = Convert.ToDouble(Console.ReadLine());

            a = new Point(x1, y1);
            b = new Point(x2, y2);
        }
    }
}
