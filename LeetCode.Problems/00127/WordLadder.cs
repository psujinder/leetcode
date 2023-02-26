namespace LeetCode.Problems;

using System.Text.RegularExpressions;

public class WordLadder{

    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

    public int LadderLength(string beginWord, string endWord, IList<string> wordList){

        int ans = 0;

        BuildGraph(wordList);

        return ans;
    }

    private void BuildGraph(IList<string> wordList){

        foreach(string word in wordList){
            for(int i=0; i< word.Length;i++){
                string key = word.Substring(0,i)+"*"+word.Substring(i+1, word.Length-1-i);

                if(map.ContainsKey(key)){
                    map[key].Add(word);
                }else{
                    map.Add(key, new List<string>(){word});
                }
            }
        }

    }

    
}
