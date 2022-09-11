namespace LeetCode.Problems;

public class TopKFrequentWords {

    public IList<string> TopKFrequent(string[] words, int k){

        var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!counts.ContainsKey(word))
                    counts[word] = 1;
                else
                    counts[word]++;
            }

            var heap = new SortedDictionary<(string,int), int>(new CustomCompare());

            foreach (var word in counts.Keys)
            {
                heap[(word, counts[word])] = 1;
                if (heap.Count > k)
                    heap.Remove(heap.Keys.First());
            }

            var results = new List<string>();
            foreach ((string word, int count) in heap.Keys)
                results.Add(word);

            results.Reverse();
            return results;
    }

}

public class CustomCompare: IComparer<(string word, int count)>  {

   public int Compare((string word, int count) a, (string word, int count)b){

        var result = a.count.CompareTo(b.count);
        if( result == 0){
            result = -a.word.CompareTo(b.word);
        };

        return result;
   }

}