namespace LeetCode.Problems;

public class MinInRotatedSortedArray2{

    public int FindMin(int[] nums) {
        
        int l = 0, r = nums.Length-1;
        int mid;

        while (l<r){
            mid = l+ (r-l)/2;

            if(nums[mid] > nums[r]){
                l = mid+1;
            }else if (nums[mid] < nums[l]){
                r = mid;
            }else{
                r--;
            }
        }
        
        return nums[l];
    }

}