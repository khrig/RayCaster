using System;
using System.Collections.Generic;

namespace RayCasting
{
    public class SomeOtherBresenHam : IBresenHamAlgorithm {

        /********
         * 
         * Should not create this many objects !
         * 
         *********/

        public List<Point> Line(int x0, int y0, int x1, int y1) {
            List<Point> points = new List<Point>();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true) {
                points.Add(new Point(x0, y0));

                if (x0 == x1 && y0 == y1)
                    break;

                int e2 = err*2;
                if (e2 > -dx) {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx) {
                    err += dx;
                    y0 += sy;
                }
            }

            return points;
        }
    }
}
