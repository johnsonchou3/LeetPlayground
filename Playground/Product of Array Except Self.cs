namespace Playground;

public class Product_of_Array_Except_Self
{
    // Time: O(N), Space O(1)
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        var store = 1;
        result[0] = 1;
        //Get Forward Products
        for (int i = 1; i < result.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        //Multiply BackwardProducts
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= store;
            store *= nums[i];
        }
        return result;
    }
}