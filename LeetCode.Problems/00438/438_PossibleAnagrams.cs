namespace LeetCode.Problems;

public class PossibleAnagrams{

    public IList<int> FindAnagrams(string s, string p){

        List<int> anagramIdx = new List<int>();
        Dictionary<char,int> hashmapP = new Dictionary<char, int>();
        Dictionary<char,int> hashmapS = new Dictionary<char, int>();

        foreach(char ch in p){
            if(hashmapP.ContainsKey(ch)){
                hashmapP[ch] ++;
            }else{
                hashmapP.Add(ch, 1);
            }
        }

        int i =0;
        int j =1;
        while(i < s.Length){

            char ch = s[i];

            if(hashmapS.ContainsKey(ch)){
                hashmapS[ch] ++;
            }else{
                hashmapS.Add(ch,1);
            }

            
            if(j == hashmapP.Count){
                if(hashmapP.OrderBy(x=>x.Key).SequenceEqual(hashmapS.OrderBy(x=>x.Key))){
                    anagramIdx.Add(i-p.Length+1);
                }
                i = i-p.Length +1;
                j=1;
                hashmapS.Clear();
            }
            /*if (i >= p.Length){
                ch = s[i-p.Length];
                if(hashmapS[ch] == 1){
                    hashmapS.Remove(ch);
                }else{
                    hashmapS[ch] ++;
                }
            }*/
            i++;
            j++;
            
        }
        return anagramIdx;
    }
}
