namespace LeetCode.Problems;

public class Permutations {

    List<IList<int>> results = new List<IList<int>>();


    public IList<IList<int>> Permute(int[] nums) {

        backtrack(nums.Length, nums.ToList(), 0);
        return results;
    }

    public void backtrack(int n, List<int> nums, int i){

        if(i == n){
            results.Add(new List<int>(nums));
            return;
        }

        for(int idx = i; idx < n; idx++){

            var tmp = nums[i];
            nums[i] = nums[idx];
            nums[idx] = tmp;


            backtrack(n,nums, i+1);

            var tmp2 = nums[i];
            nums[i] = nums[idx];
            nums[idx] = tmp2;
        }

    }

}