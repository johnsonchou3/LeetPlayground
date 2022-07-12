using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class MatchstickstoSquare
    {
        public bool Makesquare(int[] matchsticks)
        {
            int sum = matchsticks.Sum();
            if (sum % 4 != 0) return false;

            int sideLength = sum / 4;
            int[] sides = new int[4];
            int[] orderedMatchsticks = matchsticks.OrderByDescending(x => x).ToArray();
            return Solve(0);

            bool Solve(int index)
            {
                if (index == matchsticks.Length)
                {
                    for (int i = 1; i < sides.Length; i++)
                    {
                        if (sides[i] != sides[i - 1]) return false;
                    }

                    return true;
                }

                for (int i = 0; i < sides.Length; i++)
                {
                    int oldSideLength = sides[i];
                    int newSideLength = oldSideLength + orderedMatchsticks[index];
                    if (newSideLength <= sideLength)
                    {
                        sides[i] = newSideLength;
                        if (Solve(index + 1)) return true;
                        sides[i] = oldSideLength;
                    }
                }

                return false;
            }
        }
    }
}
