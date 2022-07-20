using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class MaxAreaofIslandLeet
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var maxArea = 0;    
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        grid[i][j] = 0;
                        maxArea = Math.Max(maxArea, DFS(i, j));
                    }
                }
            }
            return maxArea;

            int DFS(int i, int j)
            {
                int totalArea = 1;
                if (j!= 0 &&  grid[i][j - 1] == 1)
                {
                    grid[i][j - 1] = 0;
                    totalArea += DFS(i, j - 1);
                }
                if (j!= grid[0].Length - 1 && grid[i][j + 1] == 1)
                {
                    grid[i][j + 1] = 0;
                    totalArea += DFS(i, j + 1);
                }
                if (i!= 0 && grid[i - 1][j] == 1)
                {
                    grid[i - 1][j] = 0;
                    totalArea += DFS(i - 1, j);
                }
                if (i != grid.Length - 1 && grid[i + 1][j] == 1)
                {
                    grid[i + 1][j] = 0;
                    totalArea += DFS(i + 1, j);
                }
                return totalArea;
            }
        }
    }
}
