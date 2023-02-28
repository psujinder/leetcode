namespace LeetCode.Problems;

public class MissingRanges{
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {

        int curr, prev;
        List<string> result = new List<string>();

        prev = lower-1;

        for(int i=0; i< nums.Length; i++){
            curr = (i==nums.Length)?upper+1:nums[i];

            if (curr - prev >=2){
                result.Add(AddMissingRange(prev+1, curr-1));
            }

            prev = curr;
        }

        return result;
    }

    private string AddMissingRange(int num1, int num2){
        if(num1 == num2){
            return $"{num1}";
        }else{
            return $"{num1}->{num2}";
        }
    }
}