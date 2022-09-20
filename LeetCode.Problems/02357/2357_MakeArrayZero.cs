namespace LeetCode.Problems;

//The solution is the count the first occurance of each non zero positive integer


public class MakeArrayZeroBySubtractingEqualAmounts{

    public int MinimumOperations(int[] nums){

        List<int> uniqueNums = new List<int>();
    

        foreach(int num in nums){
            if(!uniqueNums.Contains(num)  && num > 0){
                uniqueNums.Add(num);
            }
        }

        return uniqueNums.Count;
    }

}