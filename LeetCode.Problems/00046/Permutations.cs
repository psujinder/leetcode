namespace LeetCode.Problems;

public class Permutations {

    List<IList<int>> results = new List<IList<int>>();


    public IList<IList<int>> Permute(int[] nums) {

        backtrack(nums.Length, nums.ToList(), 0);
        return results;
    }

    public void backtrack(int n, List<int> nums, int first){

        if(first == n){
            results.Add(new List<int>(nums));
            return;
        }

        for(int idx = first; idx < n; idx++){

            var tmp = nums[first];
            nums[first] = nums[idx];
            nums[idx] = tmp;


            backtrack(n,nums, first+1);

            var tmp2 = nums[first];
            nums[first] = nums[idx];
            nums[idx] = tmp2;
        }

    }

}