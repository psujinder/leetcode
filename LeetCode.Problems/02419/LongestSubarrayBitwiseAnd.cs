namespace LeetCode.Problems;

public class LongestSubarrayBitwiseAnd{

    public int LongestSubarray(int[] nums) {

       int max = 1;
       int count = 0;
       int result = 0;

       for(int i=0; i< nums.Length; i++){

            if(nums[i] == max){
                count++;
                result = Math.Max(result, count);
            }else if (nums[i] > max){
                max = nums[i];
                count = 1;
                result = 1;
            }else{
                count = 0;
            }
       }

       return result;
       
    }

}