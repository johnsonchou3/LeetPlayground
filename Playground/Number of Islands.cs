namespace Playground;

public class Number_of_Islands
{
    public int NumIslands(char[][] grid)
    {
        var islandCount = 0;
        var n = grid.Length;
        var m = grid[0].Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == '1')
                {
                    islandCount++;
                    DFS(i, j);
                }
            }
        }

        return islandCount;
        
        void DFS(int i, int j)
        {
            if (i < 0 || j < 0 || i >= n || j >= m)
            {
                return;
            }
            if (grid[i][j] == '0')
            {
                return;
            }
            grid[i][j] = '0';
            DFS(i - 1, j);
            DFS(i + 1, j);
            DFS(i, j - 1);
            DFS(i, j + 1);
        }
    }
}