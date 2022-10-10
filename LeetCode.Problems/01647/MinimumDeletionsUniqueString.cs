namespace LeetCode.Problems;

public class MinimumDeletionsUniqueString{

    public int MinDeletions(string s) {
        
        Dictionary<char,int> map = new Dictionary<char, int>();
        int deletions = 0;
    
        foreach(char ch in s){
            if(map.ContainsKey(ch)){
                map[ch]++;
            }else{
                map.Add(ch,1);
            }
        }

        List<int> freq = new List<int>();

        foreach(char ch in map.Keys){
            int value = map[ch];

            while(freq.Contains(value)){
                value --;
                deletions ++;
            }
            if( value != 0)
                freq.Add(value);
        }

        return deletions;
    }

}