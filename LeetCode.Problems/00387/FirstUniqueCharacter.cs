namespace LeetCode.Problems;

public class FirstUniqueCharacter{

    public int FirstUniqChar(string s) {

        Dictionary<char, int> count = new Dictionary<char, int>();

        for(int i=0; i< s.Length; i++){
            if(count.ContainsKey(s[i])){
                count[s[i]]++;
            }else{
                count.Add(s[i],1);
            }
        }

        for(int i=0; i< s.Length; i++){
            if(count[s[i]] == 1){
                return i;
            }
        }

        return -1;

    } 

}