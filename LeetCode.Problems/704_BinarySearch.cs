namespace LeetCode.Problems;

public class BinarySearch{
    public int Search(int[] nums, int target){

        int left = 0;
        int right = nums.Length - 1;
        int idx = 0;

        while (left <= right){
            idx = left + right /2;
            if(nums[idx] == target){
                return idx;
            }  

            if (nums[idx] < target){
                left = idx + 1;
            }

            if (nums[idx] > target){
                right = idx - 1;
            }
        }
        return -1;
    }
}