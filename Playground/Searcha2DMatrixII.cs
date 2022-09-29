using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class Searcha2DMatrixII
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }
                    if (matrix[i][j] > target)
                    {
                        break;
                    }
                }
            }
            return false;
        }
    }
}
