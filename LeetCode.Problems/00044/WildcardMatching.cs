namespace LeetCode.Problems;

public class WildcardMatching{

    bool[][] dp;

    public bool IsMatch(string s, string p) {
        
        bool isMatch = true;
        p = Cleanup(p);
        dp = new bool[s.Length][];

        //isValid(s,p,)
        return dp[s.Length-1][p.Length-1];
    } 

    private string Cleanup(string p){

        string cleanedString = "";

        for(int i=0; i< p.Length; i++){
            if(p[i]!= '*' || i-1 <0){
                cleanedString += p[i];
            }else{
                if(p[i-1] == '*'){
                    continue;
                }else{
                    cleanedString += p[i];
                }
            }
        }

        return cleanedString;
    }
}