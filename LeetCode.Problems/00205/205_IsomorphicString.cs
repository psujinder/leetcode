namespace LeetCode.Problems;

public class IsomorphicString{

    public bool IsIsomorphic(string s, string t){


        if(s.Length != t.Length){
            return false;
        }

        int[] mappingStoT = new int[256];
        Array.Fill(mappingStoT, -1);

        int[] mappingTtoS = new int[256];
        Array.Fill(mappingTtoS, -1);
        
        for(int i = 0; i< s.Length; i++){
            var c1 = s[i];
            var c2 = t[i];

            if(mappingStoT[c1] == -1 && mappingTtoS[c2] == -1){
                mappingStoT[c1] = c2;
                mappingTtoS[c2] = c1;
            }
            else if (mappingStoT[c1] != c2 ||  mappingTtoS[c2] != c1){
                return false;    
            }

        }

       return true;

    }

}