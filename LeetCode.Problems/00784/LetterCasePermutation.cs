namespace LeetCode.Problems;

public class LetterCasePermutation{

    List<string> results = new List<string>();
    
    public IList<string> LetterCasePermute(string s) {
        
        backtrack(s,0);
        return results;
    } 

    private void backtrack(string s, int i){

        if(i == s.Length){
            if(!results.Contains(s)){
            results.Add(s);
            }
        }

        for(int idx = i; i< s.Length; i++){
            s = s.Replace(s[idx], char.ToUpper(s[idx]));
            backtrack(s, i+1);
            s = s.Replace(s[idx], char.ToLower(s[idx]));


            s = s.Replace(s[idx], char.ToLower(s[idx]));
            backtrack(s, i+1);
            s = s.Replace(s[idx], char.ToUpper(s[idx]));
        }

    }

}