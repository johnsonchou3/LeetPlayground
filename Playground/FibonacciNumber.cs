using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class FibonacciNumber
    {
        public int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i < n + 1; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
}
