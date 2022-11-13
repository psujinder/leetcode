namespace LeetCode.Problems;

public class ProductOfArrayExceptSelf{

    public int[] ProductExceptSelf(int[] nums) {
        
        int[] ans = new int[nums.Length];

        //left product
        ans[0] = 1;

        for(int i=1; i< nums.Length; i++){
            ans[i] = ans[i-1] * nums[i-1];
        }

        //right product
        int right = 1;

        for(int i = nums.Length-2; i>=0; i--){
            right = right * nums[i+1];
            ans[i] = ans[i] * right;
        }

        return ans;

    }


}