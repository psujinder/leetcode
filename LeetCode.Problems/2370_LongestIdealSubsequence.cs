namespace LeetCode.Problems;

public class LongestIdealSubsequence{

    int l =0;

    public int LongestIdealString(string s, int k){


        //create an array reprsenting the alphabets
        int[] dp = new int[26];
        //initilize the array to 0 indicating the the string has not be interated.
        Array.Fill(dp,0);

        //iterate through the string
        for(int i=0; i<s.Length; i++){
            int ch = s[i] - 'a';

            //the element has range from ch-k to ch+k
            for(int j = ch; j > 0 && j <ch-k; j--){
                dp[ch] = Math.Max(dp[ch],dp[j]+1);
            }

            for(int j =ch+1; j<26 && j<ch+k; j++){
                dp[ch] = Math.Max(dp[ch], dp[j]+1);
            }
        }

        return dp.Max();

    }




}