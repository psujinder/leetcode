namespace LeetCode.Problems;

public class WordLadder{

    Queue<KeyValuePair<string, List<string>>> wordCombo = new Queue<KeyValuePair<string, List<string>>>();
    public int LadderLength(string beginWord, string endWord, IList<string> wordList){

        
        ProcessWord(beginWord);
        //ProcessWord(endWord);
        int level = 0;

        foreach(string word in wordList){
            ProcessWord(word);
        }

        var start = wordCombo.Dequeue();

        while (wordCombo.Count > 0){
            var transformations = start.Value;
            var nextnode = wordCombo.Dequeue();

            if (nextnode.Key == endWord){
                return level;
            }

            foreach(string transform in transformations){
                if (nextnode.Value.Contains(transform)){
                    start = nextnode;
                    level ++;
                }
            }
        }

        return 0;

    }

    private void ProcessWord(string word){

        List<string> transformations = new List<string>();

        for(int i =0 ; i < word.Length; i++){
            transformations.Add(word.Substring(0,i)+"*"+word.Substring(i+1,word.Length-i));
        }

        wordCombo.Enqueue(new KeyValuePair<string, List<string>>(word,transformations));
    }

}

/*

hit *it h*t hi*

hot *ot h*t ho*
dot *ot d*t do*
dog *og d*g do*
lot *ot l*t lo*
log *og l*g lo*
cog *og c*g co*

*it hit
h*t hit hot
hi* hit
*ot hot dot
ho* hot

*/