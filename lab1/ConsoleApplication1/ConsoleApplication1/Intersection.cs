using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Intersection
    {
        static void Main(string[] args)
        {
            Line first = new Line();
            Line second = new Line();
            Console.WriteLine("Enter the coordinates of the points of the first line");
            first.init();
            Console.WriteLine("Enter the coordinates of the points of the second line");
            second.init();
            CalcOfPoint c = new CalcOfPoint();
            Point q;
            q = c.Back(first, second);
            Console.Write("x=");
            Console.WriteLine(q.x);
            Console.Write("y=");
            Console.WriteLine(q.y);
            Console.ReadKey();
        }

    }
}
