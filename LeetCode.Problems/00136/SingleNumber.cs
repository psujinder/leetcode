namespace LeetCode.Problems;

public class SingleNumberPR {

    public int SingleNumber(int[] nums) {
        
        HashSet<int> set = new HashSet<int>();

        int sumOfSet = 0;
        int sumOfNums = 0;

        foreach(int num in nums){
            if(!set.Contains(num)){
                set.Add(num);
                sumOfSet += num;
            }

            sumOfNums += num;
        }

        return 2 * sumOfSet - sumOfNums;

    } 

}