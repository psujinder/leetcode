namespace LeetCode.Problems;

public class IsomorphicString{

    public bool IsIsomorphic(string s, string t){

        if(s.Length != t.Length){
            return false;
        }

        Dictionary<char, char> hashmap = new Dictionary<char, char>();

        for(int i= 0; i < s.Length; i++){
            
            if(hashmap.ContainsKey(s[i]) || hashmap.ContainsValue(t[i])){
                if(hashmap[s[i]] == t[i] && hashmap[t[i]] == s[i]){
                    continue;
                }else{
                    return false;
                }
            }
            else{               
                hashmap.Add(s[i],t[i]);                
            }
        }


        return true;

    }

}