using System;

namespace RayCasting {
    public class Positions {
        private readonly int costMultipler;

        public Positions(int costMultipler) {
            this.costMultipler = costMultipler;
        }

        public int[,] GetNearestPositions(int[,] grid, int x, int y, int gridSearchLength, int maxDistanceCost, int blocked, int newValue) {
            int startPosX = Math.Max(x - gridSearchLength, grid.GetLowerBound(1));
            int endPosX = Math.Min(x + gridSearchLength, grid.GetUpperBound(1));
            int startPosY = Math.Max(y - gridSearchLength, grid.GetLowerBound(0));
            int endPosY = Math.Min(y + gridSearchLength, grid.GetUpperBound(0));
            for (int rowNum = startPosX; rowNum <= endPosX; rowNum++) {
                for (int colNum = startPosY; colNum <= endPosY; colNum++) {
                    if (EuclideanDistance(x, y, rowNum, colNum) <= maxDistanceCost)
                        if (grid[colNum, rowNum] != blocked)
                            grid[colNum, rowNum] = newValue;
                }
            }
            return grid;
        }

        public int ManHattanDistance(int x, int y, int rowNum, int colNum) {
            return Math.Abs(rowNum - x) + Math.Abs(colNum - y);
        }

        public int EuclideanDistance(int x, int y, int rowNum, int colNum) {
            double xd = x - rowNum;
            double yd = y - colNum;
            double sqrt = Math.Sqrt((xd*xd) + (yd*yd));
            return (int)(sqrt * costMultipler);
        }
    }
}
