namespace LeetCode.Problems;

public class WordBreak_PR{

    public bool WordBreak(string s, IList<string> wordDict) {

        HashSet<string> set = new HashSet<string>(wordDict);

        bool[] dp = new bool[s.Length+1];
        dp[0] = true;

        for(int j=1; j<s.Length; j++){
            for(int i=0; i<j; i++){
                if(dp[i] && set.Contains(s.Substring(i, j-i))){
                    dp[j] = true;
                    break;
                }
            }
        }

        return dp[s.Length];
    }

}