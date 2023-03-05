namespace LeetCode.Problems;

public class RotateArray{

    public void Rotate(int[] nums, int k) {
        
        int[] res = new int[nums.Length];
        int len = nums.Length;

        for(int i=0; i<nums.Length;i++){
            
            int j = (i+k) % len;
            res[j] = nums[i];

        }
        res.CopyTo(nums,0);
    } 

}