namespace LeetCode.Problems;

using System.Text.RegularExpressions;

public class WordLadder{

    List<List<string>> possibleTransformations = new List<List<string>>();
    Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

    public int LadderLength(string beginWord, string endWord, IList<string> wordList){

        //construct graph of word transformation
        BuildGraph(wordList);

        
        //process the begin word - bfs 
        Queue<string> queue = new Queue<string>();
        int count =0;
        int levelCount = 0;

        queue.Enqueue(beginWord);

        /*while(queue.Count > 0){
            string word = queue.Enqueue();
        }*/

        
        //return the transformation with the least number of strings
        return 0;
    }

    private void BuildGraph(IList<string> wordList){

        foreach(string word in wordList){
            for(int i = 0; i< word.Length; i++){
                string pattern = word.Substring(0,i)+ '.'+word.Substring(i+1);
                if(map.ContainsKey(pattern)){
                    map[pattern].Add(word);
                }else{
                    map.Add(pattern, new List<string>(){word});
                }
            }
        }
    }
}
