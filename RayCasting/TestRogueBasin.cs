using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCasting
{
    public class TestBresenSimple {
        private const int xWidth = 6;
        private const int yWidth = 5;

        public static void Test() {
            int startX = 2;
            int startY = 2;

            int[,] grid = new int[xWidth, yWidth] {
                {5, 5, 5, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {5, 1, 5, 1, 5}
            };
            grid[startX, startY] = 9;

            IBresenHamAlgorithm bresenhamRogue = new SomeOtherBresenHam();
            
            for (int i = 0; i < xWidth; i++)
            {
                var points = bresenhamRogue.Line(startX, startY, i, 0);
                foreach (Point p in points)
                {
                    if (grid[p.X, p.Y] == 5)
                        break;
                    if (grid[p.X, p.Y] != 9)
                        grid[p.X, p.Y] = 0;
                }
            }
            for (int i = 0; i < xWidth; i++)
            {
                var points = bresenhamRogue.Line(startX, startY, i, yWidth - 1);
                foreach (Point p in points)
                {
                    if (grid[p.X, p.Y] == 5)
                        break;
                    if (grid[p.X, p.Y] != 9)
                        grid[p.X, p.Y] = 0;
                }
            }
            for (int i = 0; i < yWidth; i++)
            {
                var points = bresenhamRogue.Line(startX, startY, 0, i);
                foreach (Point p in points)
                {
                    if (grid[p.X, p.Y] == 5)
                        break;
                    if (grid[p.X, p.Y] != 9)
                        grid[p.X, p.Y] = 0;
                }
            }
            for (int i = 0; i < yWidth; i++)
            {
                var points = bresenhamRogue.Line(startX, startY, xWidth - 1, i);
                foreach (Point p in points)
                {
                    if (grid[p.X, p.Y] == 5)
                        break;
                    if (grid[p.X, p.Y] != 9)
                        grid[p.X, p.Y] = 0;
                }
            }
            GridPrinter.Print(grid);
        }
    }
}
