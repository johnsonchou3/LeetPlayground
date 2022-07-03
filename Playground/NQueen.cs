using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class NQueen
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var columns = new HashSet<int>();
            var posDiag = new HashSet<int>(); // r+c
            var negDiag = new HashSet<int>(); // r-c
            var result = new List<IList<string>>();
            BackTracking(0, new List<string>());
            void BackTracking(int r, List<string> prevRows)
            {
                for (int c = 0; c < n; c++)
                {
                    var s = new String('.', n);
                    if (columns.Contains(c) || posDiag.Contains(r + c) || negDiag.Contains(r - c))
                    {
                        continue;
                    }
                    s = s.Remove(c, 1);
                    s = s.Insert(c, "Q");
                    var rows = new List<string>(prevRows);
                    rows.Add(s);
                    if (r == n - 1)
                    {
                        result.Add(rows);
                    }
                    else
                    {
                        columns.Add(c);
                        posDiag.Add(r + c);
                        negDiag.Add(r - c);
                        BackTracking(r + 1, rows);
                        columns.Remove(c);
                        posDiag.Remove(r + c);
                        negDiag.Remove(r - c);
                    }
                }
            }
            return result;
        }
    }
}
