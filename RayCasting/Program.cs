using System;

namespace RayCasting {
    internal class Program {
        private static void Main(string[] args) {
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 5, 5, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1}
            };

            Positions positionCount = new Positions(10);

            int startX = 2;
            int startY = 3;
            int ap = 20;
            int moveLengthUnits = ap/10;
            GridPrinter.Print(grid);
            int[,] positions = positionCount.GetNearestPositions(grid, startX, startY, moveLengthUnits, ap, 5, 3);
            GridPrinter.Print(positions);

            Fov fov = new Fov();
            fov.SetFov(grid, startX, startY, 5, 0);
            grid[startY, startX] = 1;
            GridPrinter.Print(grid);


            Console.Read();
        }
    }
}
