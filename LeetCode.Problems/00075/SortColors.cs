namespace LeetCode.Problems;

public class SortColorsProblem{
    public void SortColors(int[] nums){

        int p0=0;
        int p2 = nums.Length-1;
        int curr = 0;
        int tmp;

        while (curr <= p2){
            if(nums[curr] == 0){
                tmp = nums[p0];
                nums[p0] = nums[curr];
                nums[curr] = tmp;
                p0++;
                curr++;
            }else if(nums[curr] == 2){
                tmp = nums[curr];
                nums[curr] = nums[p2];
                nums[p2] = tmp;
                p2--;
            }
            else curr++;
        }
    }
}