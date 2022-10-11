namespace LeetCode.Problems;

public class SearchInRotatedSortedArray{

    public int Search(int[] nums, int target) {
        
        if(nums.Length ==1 && nums[0] == target){
            return 0;
        }

        int l =0, r = nums.Length-1;
        int mid;

        while(l<=r){
            mid = l + (r-l)/2;

            if(nums[mid] == target){
                return mid;
            }
            
            if (nums[mid] >= nums[l]) {
                if (target >= nums[l] && target < nums[mid]) 
                    r = mid - 1;
                else 
                    l = mid + 1;
            }
            else {
                if (target <= nums[r] && target > nums[mid]) 
                    l = mid + 1;
                else 
                    r = mid - 1;
            }
        }

        return -1;
    } 

}