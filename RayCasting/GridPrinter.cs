using System;

namespace RayCasting {
    public static class GridPrinter {
        public static void Print(int[,] grid, bool clearScreen) {
            if(clearScreen)
                Console.Clear();
            Print(grid);
        }

        public static void Print(int[,] grid) {
            Console.WriteLine();
            for (int y = 0; y < grid.GetLength(0); y++) {
                for (int x = 0; x < grid.GetLength(1); x++) {
                    Console.Write(grid[y, x] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
