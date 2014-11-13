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


            RunFovTest1();
            RunFovTest2();
            RunFovTest3();
            RunFovTest4();
            RunFovTest5();
            RunFovTest6();
            Console.Read();
        }

        private static void RunFovTest1()
        {
            int startX = 2;
            int startY = 3;
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 5, 5, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1}
            };

            Fov fov = new Fov();
            fov.SetFov(grid, startX, startY, 5, 0);
            grid[startY, startX] = 1;
            Console.WriteLine("Test 1");
            GridPrinter.Print(grid);
        }

        private static void RunFovTest2()
        {
            int startX = 2;
            int startY = 3;
            int[,] grid = new int[6, 5] {
                {5, 1, 1, 1, 1},
                {1, 5, 5, 5, 1},
                {1, 1, 5, 5, 1},
                {1, 1, 1, 5, 1},
                {1, 5, 1, 1, 5},
                {1, 1, 1, 1, 1}
            };

            Fov fov = new Fov();
            fov.SetFov(grid, startX, startY, 5, 0);
            grid[startY, startX] = 1;
            Console.WriteLine("Test 2");
            GridPrinter.Print(grid);
        }

        private static void RunFovTest3()
        {
            int startX = 2;
            int startY = 3;
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1}
            };
            
            FovTestRunner.Run(startX, startY, grid, "Test 3");
        }

        private static void RunFovTest4()
        {
            int startX = 2;
            int startY = 2;
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1}
            };

            FovTestRunner.Run(startX, startY, grid, "Test 4");
        }

        private static void RunFovTest5()
        {
            int startX = 2;
            int startY = 2;
            int[,] grid = new int[6, 5] {
                {1, 1, 5, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 5, 1, 1}
            };

            FovTestRunner.Run(startX, startY, grid, "Test 5");
        }

        private static void RunFovTest6()
        {
            int startX = 2;
            int startY = 2;
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 5, 1, 1}
            };

            FovTestRunner.Run(startX, startY, grid, "Test 6");
        }
    }
}
