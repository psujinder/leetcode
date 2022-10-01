namespace LeetCode.Problems;

public class SortPeople{

    public string[] Sort(string[] names, int[] heights){

        Dictionary<int,string> order = new Dictionary<int, string>();
        
        for(int i=0; i < heights.Length; i++){
            order.Add(heights[i], names[i]);
        }

        var sorted = order.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x=> x.Value);

        return  sorted.Values.ToArray();

    }

}