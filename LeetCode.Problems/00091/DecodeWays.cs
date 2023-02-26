namespace LeetCode.Problems;

public class DecodeWays{

    public int NumDecodings(string s) {
        
        if(s == null || s.Length == 0){
            return 0;
        }

        int len = s.Length;
        int[] dp = new int[len+1];

        dp[0]=1;
        dp[1] = s[0] == '0'? 0:1;

        for(int i=2; i<= len; i++){

            int oneDigit = int.Parse(s.Substring(i-1,1));
            int twoDigit = int.Parse(s.Substring(i-2,2));

            if( oneDigit >= 1 && oneDigit <=9){
                dp[i] += dp[i-1];
            }

            if( twoDigit >= 10 && twoDigit <=26){
                dp[i] += dp[i-2];
            }
        }

        return dp[len];
    }
}