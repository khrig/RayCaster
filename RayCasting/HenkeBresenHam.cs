using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting
{
    public class HenkeBresenHam : IBresenHamAlgorithm
    {
        /*
         function switchToOctantZeroFrom(octant, x, y) 
            switch(octant)  
             case 0: return (x,y)
             case 1: return (y,x)
             case 2: return (-y, x)
             case 3: return (-x, y)
             case 4: return (-x, -y)
             case 5: return (-y, -x)
             case 6: return (y, -x)
             case 7: return (x, -y)

             Octants:
              \2|1/
              3\|/0
             ---+---
              4/|\7
              /5|6\
         * */

        public Point SwitchByOctant(int octant, int x, int y)
        {
            switch (octant)
            {
                case 0:
                    return new Point(x, y);
                case 1:
                    return new Point(y, x);
                case 2:
                    return new Point(-y, x);
                case 3:
                    return new Point(-x, y);
                case 4:
                    return new Point(-x, -y);
                case 5:
                    return new Point(-y, -x);
                case 6:
                    return new Point(y, -x);
                case 7:
                    return new Point(x, -y);
                default:
                    throw new ArgumentException(octant.ToString());
            }
        }

        public void Plot(int[,] grid, int x, int y, int x2, int y2)
        {
            
        }


        public List<Point> Line(int x0, int y0, int x1, int y1)
        {
            List<Point> points = new List<Point>();

            int dx = x1 - x0;
            int dy = y1 - y0;
            int D = 2*dy - dx;

            // plot(x0,y0)
            int y = y0;
            for (int x = x0 + 1; x <= x1; x++)
            {
                if (D > 0)
                {
                    y = y + 1;
                    // plot(x,y)
                    points.Add(new Point(x, y));
                    D = D + (2*dy - 2*dx);
                }
                else
                {
                    // plot(x,y)
                    points.Add(new Point(x, y));
                    D = D + (2*dy);
                }
            }
            return points;
        }
    }
}
