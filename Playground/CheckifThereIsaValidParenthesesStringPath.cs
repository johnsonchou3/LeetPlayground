using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class CheckifThereIsaValidParenthesesStringPath
    {
        private int MatrixHeight;
        private int MatrixWidth;
        private bool IsThereIsaValidParentheses = false;
        private char[][] Grid;
        // O(2^m*n)
        public bool HasValidPath_BruteForce(char[][] grid)
        {
            MatrixHeight = grid.Length;
            MatrixWidth = grid[0].Length;
            Grid = grid;
            Recurse(0, 0, 0, 0);
            return IsThereIsaValidParentheses;
        }

        private void Recurse(int width, int height, int openCount, int closeCount)
        {
            if (Grid[height][width] == '(')
            {
                openCount++;
            }
            else
            {
                closeCount++;
            }
            if (openCount  <  closeCount)
            {
                return;
            }
            if (width == MatrixWidth - 1 && height == MatrixHeight - 1)
            {
                if (openCount == closeCount)
                {
                    IsThereIsaValidParentheses = true;
                    return;
                }
            }
            else if (width == MatrixWidth - 1)
            {
                Recurse(width, height + 1, openCount, closeCount);
            }
            else if (height == MatrixHeight - 1)
            {
                Recurse(width + 1, height, openCount, closeCount);
            }
            else
            {
                Recurse(width, height + 1, openCount, closeCount);
                Recurse(width + 1, height, openCount, closeCount);
            }
        }

        public bool HasValidPath_DP(char[][] grid)
        {
            if (grid[0][0] != '(')
            {
                return false;
            }
            var Height = grid.Length;
            var Width = grid[0].Length;
            // [i][j] = Set of Counts
            var dp = new HashSet<int>[Height][];
            for (int i = 0; i < Height; i++)
            {
                dp[i] = new HashSet<int>[Width];
            }
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    var openCount = grid[i][j] == '('? 1: -1;
                    dp[i][j] = new HashSet<int>();
                    if (i == 0 && j == 0)
                    {
                        dp[i][j].Add(1);
                    }
                    if (i - 1 >=  0)
                    {
                        foreach (var val in dp[i - 1][j])
                        {
                            if (val + openCount >= 0)
                            {
                                dp[i][j].Add(val + openCount);
                            }
                        } 
                    }
                    if (j - 1 >=  0)
                    {
                        foreach (var val in dp[i ][j - 1])
                        {
                            if (val + openCount >= 0)
                            {
                                dp[i][j].Add(val + openCount);
                            }
                        }
                    }
                }
            }
            return dp[Height - 1][Width - 1].Contains(0);
        }

    }
}
