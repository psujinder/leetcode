namespace LeetCode.Problems;

public class PowerOfThree{

    public bool IsPowerOfThree(int n) {

        if (n<=0){
            return false;
        }

        while (n%3==0){
            n = n/3;
        }

        return (n==1);

    }

}