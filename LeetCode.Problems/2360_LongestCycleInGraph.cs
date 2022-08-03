namespace LeetCode.Problems;

public class LongestCycleInGraph{

        private Dictionary<int,int> graph = new Dictionary<int, int>();

    public int LongestCyce(int[] edges){

        var visited = new int[ edges.Length];
        Array.Fill(visited, -1);

        var maxValue = 0;
        for (var i = 0; i < edges.Length; i++) {
            if (visited[i] >= 0) continue;

            var nodePath = new HashSet<int>();
            var node = i;
            var count = 0;
            while (node != -1 && visited[node] == -1) {
                nodePath.Add(node);
                visited[node] = count++;
                node = edges[node];
            }

            if (nodePath.Contains(node))
                maxValue = Math.Max(maxValue, count - visited[node]);
    }

    return maxValue == 0 ? -1 : maxValue;
    }
}