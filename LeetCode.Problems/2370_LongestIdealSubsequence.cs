namespace LeetCode.Problems;

public class LongestIdealSubsequence{

    int l =0;

    public int LongestIdealString(string s, int k){

        int[] dp = new int[26];
        Array.Fill(dp,0);

        for(int i = 0; i< s.Length; i++){

            int ch = s[i] - 'a';

            for(int j = ch; j >=0 && j >= ch-k; j--){
                dp[ch] = Math.Max(dp[ch], dp[j]+1);
            }

            for(int j=ch+1; j <26 && j <= ch+k; j++){
                dp[ch] = Math.Max(dp[ch], dp[j]+1);
            }
        }

        return dp.Max();

    }




}