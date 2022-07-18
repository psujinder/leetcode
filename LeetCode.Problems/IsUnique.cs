namespace LeetCode.Problems;

public class StringOps{

    public bool IsUnique(string s){

        bool[] exists = new bool[128];

        for(int i = 0; i < s.Length; i++){
            int ch = s[i];
            if(exists[ch])
                return false;
            else{
                exists[ch] = true;
            }
        }

        return true;

    }

    public bool IsPermutation(string s1, string s2){

        s1 = s1.ToLower();
        s2 = s2.ToLower();

        s1 = String.Join("", s1.ToArray().OrderByDescending(x => x));
        s2 = String.Join("", s1.ToArray().OrderByDescending(x => x));

        return s1.Equals(s2);

    }

    public string ReplaceString(string s1){

        

        return s1;
    }

}