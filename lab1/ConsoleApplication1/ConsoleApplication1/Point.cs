using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Point
    {
        public double x;
        public double y;
        public Point(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public override bool Equals(object obj)
        {
            Point p = (Point)obj;

            if (x == p.x && y == p.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

