namespace LeetCode.Problems;

public class MinInRotatedSortedArray{
    public int FindMin(int[] nums) {
        
        int l = 0, r = nums.Length-1;
        int pivot;

        if(nums.Length == 1){
            return nums[0];
        }

        if (nums[r] > nums[0]){
            return nums[0];
        }

        while(l<=r){
            pivot = l+ (r-l)/2;

            if(nums[pivot] > nums[pivot+1]){
                return nums[pivot+1];
            }

            if(nums[pivot-1]> nums[pivot]){
                return nums[pivot];
            }

            if(nums[pivot] > nums[0]){
                l = pivot+1;
            }else{
                r = pivot -1;
            }
        }

        return int.MaxValue;
    }
}