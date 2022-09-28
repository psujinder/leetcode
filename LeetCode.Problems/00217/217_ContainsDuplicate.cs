namespace LeetCode.Problems;

public class ContainsDuplicateNumbers {

    public bool ContainsDuplicate (int[] nums) {

        bool containsDuplicate = false;

        List<int> list = new List<int>();

        for(int i =0; i < nums.Length; i++){

            if(list.Contains(nums[i])){
                return true;
            }

            list.Add(nums[i]);

        }

        return containsDuplicate;

    }

}