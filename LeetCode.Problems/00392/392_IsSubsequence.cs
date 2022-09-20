namespace LeetCode.Problems;

public class CheckSubsequece{

    public bool IsSubsequence (string s, string t){

        int idx_s = 0;

        if (s.Length == 0)
            return true;

        if (s.Length > t.Length)
            return false;
        

        for(int i =0; i< t.Length; i++){
            if(t[i] == s[idx_s]){
                idx_s ++;
            }

            if(idx_s == s.Length){
                return true;
            }
        }

        return false;
    }

}