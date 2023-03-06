namespace LeetCode.Problems;

public class PalindromePartitioning{

    public IList<IList<string>> Partition(string s) {

        if (s == null){
            return null;
        }

        List<IList<string>> result = new List<IList<string>>();
        List<string> current = new List<string>();

        if(s.Length == 1){
           result.Add(new List<string>(){char.ToString(s[0])});
           return result;
        }

        backtrack(s, 0, current, result);
        
        return result;
    }

    private void backtrack(string s, int start, List<string> current, List<IList<string>> result){

        if(start == s.Length){
            result.Add(current);
        }

        for(int i= start; i< s.Length;i++){
            if(IsPalin(s, start,i)){
                current.Add(s.Substring(start, i-start+1));
                backtrack(s, i+1, current, result);
                current.RemoveAt(current.Count -1);
            }
        }

    }

    private bool IsPalin(string str, int start, int end){

        while(start < end){
            if(str[start]!=str[end]){
                return false;
            }
            start++;
            end--;
        }

        return true;

    }

}