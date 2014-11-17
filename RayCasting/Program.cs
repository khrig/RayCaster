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

            PlotTest();

            TestBresenSimple.Test();

            FovTests();
            Console.Read();
        }

        private static void PlotTest()
        {
            int startx = 2;
            int starty = 2;
            int[,] grid = new int[6, 5] {
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0}
            };
            int count = 1;
            BresenhamRogueBasin.Line(startx,starty,0,0, (i, i1) => { 
                grid[i, i1] = count;
                                                             count++;
                return true;
            });
            GridPrinter.Print(grid);
        }

        private static void FovTests()
        {
            RunFovTest1();
            RunFovTest2();
            RunFovTest3();
            RunFovTest4();
            RunFovTest5();
            RunFovTest6();
            RunFovTest7();
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

            FovTestRunner.Run(startX, startY, grid, "Test 1");
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

            FovTestRunner.Run(startX, startY, grid, "Test 2");
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

        private static void RunFovTest7()
        {
            int startX = 2;
            int startY = 2;
            int[,] grid = new int[6, 5] {
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 5, 1, 5, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 5, 1, 5}
            };

            FovTestRunner.Run(startX, startY, grid, "Test 7");
        }
    }
}
