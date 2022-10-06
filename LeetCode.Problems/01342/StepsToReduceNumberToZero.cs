namespace LeetCode.Problems;

public class StepsToReduceNumberToZero{

    public int NumberOfSteps(int num) {

        int result = 0;

        while(num > 0){
            num = (num%2 == 0)? num/2: num-1;
            result++;
        }

        return result;

    }

}