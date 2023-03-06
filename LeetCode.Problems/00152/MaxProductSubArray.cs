namespace LeetCode.Problems;

public class MaxProductSubArrary{

    public int MaxProduct(int[] nums) {
        
        int result = nums[0];
        int maxProduct = nums[0];
        int minProduct = nums[0];

        for(int i = 1; i < nums.Length; i++){

            int currMax = Math.Max(nums[i], Math.Max(maxProduct*nums[i], minProduct*nums[i]));
            int currMin = Math.Min(nums[i], Math.Min(maxProduct*nums[i], minProduct*nums[i]));
            maxProduct = currMax;
            minProduct = currMin;
            result = Math.Max(result, maxProduct);        

        }

        return result;
    }

}