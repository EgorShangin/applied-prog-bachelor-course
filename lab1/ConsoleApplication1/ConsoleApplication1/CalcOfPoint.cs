using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CalcOfPoint
    {
        public Point Back(Line first, Line second)
        {
            double A1, B1, C1, A2, B2, C2;
            A1 = first.a.y - first.b.y;
            B1 = first.b.x - first.a.x;
            C1 = first.a.x * first.b.y - first.b.x * first.a.y;
            A2 = second.a.y - second.b.y;
            B2 = second.b.x - second.a.x;
            C2 = second.a.x * second.b.y - second.b.x * second.a.y;
            double x, y;
            y = (-A2 * C1 + C2 * A1) / (A2 * B1 - A1 * B2);
            x = (-C1 - B1 * y) / A1;
            return new Point(x, y);
        }
    }
}

