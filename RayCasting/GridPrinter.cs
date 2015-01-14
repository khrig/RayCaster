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
                    WriteGridPos(grid, y, x);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        private static void WriteGridPos(int[,] grid, int y, int x) {
            var color = Console.ForegroundColor;
            switch (grid[y, x]) {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                default:
                    Console.ForegroundColor = color;
                    break;
            }
            Console.Write(grid[y, x] + " ");
            Console.ForegroundColor = color;
        }
    }
}
