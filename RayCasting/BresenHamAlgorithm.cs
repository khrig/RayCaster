using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting {
    public class BresenHamAlgorithm {
        /*
            Notes
         *  - Should use struct instead of class or reuse the class instances
         * 
         * */
        // Swap the values of A and B
        private void Swap<T>(ref T a, ref T b) {
            T c = a;
            a = b;
            b = c;
        }

        // Returns the list of points from p0 to p1 
        public List<Point> Line(Point p0, Point p1) {
            return Line(p0.X, p0.Y, p1.X, p1.Y);
        }

        
        public List<Point> Line(int[,] grid, int x0, int y0, int x1, int y1) {
            List<Point> result = new List<Point>();

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            int deltax = x1 - x0;
            int deltay = Math.Abs(y1 - y0);
            int error = 0;
            int ystep;
            int y = y0;
            if (y0 < y1) ystep = 1;
            else ystep = -1;
            for (int x = x0; x <= x1; x++)
            {
                if (steep)
                {
                    if (grid[y, x] == 5)
                        return result;
                    result.Add(new Point(y, x));
                }
                else
                {
                    if (grid[x, y] == 5)
                        return result;
                    result.Add(new Point(x, y));
                }
                error += deltay;
                if (2 * error >= deltax)
                {
                    y += ystep;
                    error -= deltax;
                }
            }

            return result;
        }

        // Returns the list of points from (x0, y0) to (x1, y1)
        public List<Point> Line(int x0, int y0, int x1, int y1) {
            List<Point> result = new List<Point>();

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep) {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1) {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            int deltax = x1 - x0;
            int deltay = Math.Abs(y1 - y0);
            int error = 0;
            int ystep;
            int y = y0;
            if (y0 < y1) ystep = 1;
            else ystep = -1;
            for (int x = x0; x <= x1; x++) {
                if (steep) result.Add(new Point(y, x));
                else result.Add(new Point(x, y));
                error += deltay;
                if (2*error >= deltax) {
                    y += ystep;
                    error -= deltax;
                }
            }

            return result;
        }
    }
}
