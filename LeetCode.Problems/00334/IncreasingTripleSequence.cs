namespace LeetCode.Problems;

public class IncreatingTripleSequence{

    public bool IncreasingTriplet(int[] nums) {

       int n = nums.Length;
       int small1 = Int32.MaxValue, small2 = Int32.MaxValue;

       for(int i=0; i< n; i++){
            if(nums[i] <= small1){
                small1 = nums[i];
            }else if (nums[i] <= small2){
                small2 = nums[i];
            }else{
                return true;
            }
       } 
       
       return false;
    }

}