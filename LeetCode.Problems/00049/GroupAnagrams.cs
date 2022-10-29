namespace LeetCode.Problems;

using System.Collections.Generic;
using System.Text;

public class GroupAnagramsProblem {

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs){
            
            int[] count = new int[26];
            Array.Fill(count,0);
            foreach(char ch in s){
                var tmp = ch - 'a';
                count[tmp] ++;
            }

            StringBuilder sb = new StringBuilder();
            for(int i=0; i< 26; i++){
                sb.Append('#');
                sb.Append(count[i]);
            }

            string key = sb.ToString();
            if(map.ContainsKey(key)){
                map[key].Add(s);
            }else{
                map.Add(key, new List<string>{s});
            }
        }

        List<IList<string>> result = new List<IList<string>>();

        foreach(List<string> val in map.Values){
            result.Add(val);
        }
        return result;
    }

}