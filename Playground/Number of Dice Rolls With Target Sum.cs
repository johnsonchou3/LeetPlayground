namespace Playground;

public class Number_of_Dice_Rolls_With_Target_Sum
{
    public int NumRollsToTarget(int d, int f, int target)
    {
        int M = Convert.ToInt32(Math.Pow(10, 9) + 7);
        var dp = new int[d + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[target + 1];
        }

        dp[0][0] = 1;

        for(int i = 1;i <= d; i++) {
            for(int k = 1;  k <= target; k++) {
                for(int j=1; j <= f; j++)
                {
                    if (k >= j)
                        dp[i][k] = (dp[i][k] + dp[i - 1][k - j]) % M;
                }
            }
        }

        return dp[d][target];
    }
    
    public int NumRollsToTarget2(int d, int f, int target) {
        int M = Convert.ToInt32(Math.Pow(10,9) + 7);

        var dp = new int[d + 1, target + 1];
        
        dp[0,0] = 1;
        
        for(int i = 1;i <= d; i++) {
            for(int k = 1;  k <= target; k++) {
                for(int j=1; j <= f; j++) {
                    if(k >=j)
                        dp[i,k] = (dp[i,k] + dp[i-1,k-j]) % M;
                }
            }
        }
        return dp[d,target];

    }
}