namespace LeetCode.Problems;

public class RotateArray_2{

    public void Rotate(int[] nums, int k) {

        int len = nums.Length;

        k %= len;

        Reverse(nums,0,len-1);
        Reverse(nums,0,k);
        Reverse(nums,k, len-1);

    }

    private void Reverse(int[] nums, int start, int end){
        
        while(start<end){
            int tmp = nums[start];
            nums[start] = nums[end];
            nums[end] = tmp;
            start ++;
            end--;
        }

    }

}