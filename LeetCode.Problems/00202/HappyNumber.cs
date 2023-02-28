namespace LeetCode.Problems;

public class HappyNumber{

    public bool IsHappy(int n) {
        
        HashSet<int> set = new HashSet<int>();

        while (n!=1){
            int sum = 0;
            
            while(n!=0){
                int num = n%10;
                sum += num*num;
                n = n/10;
            }

            if(set.Contains(sum)){
                return false;
            }

            set.Add(sum);
            n = sum;
        }

        return true;
    }

}