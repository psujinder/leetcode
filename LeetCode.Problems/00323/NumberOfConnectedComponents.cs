namespace LeetCode.Problems;

public class NumberOfConnectedComponents{

    bool[] visited;
    
    public int CountComponents(int n, int[][] edges) {

        int result = 0;
        visited = new bool[n];

        List<List<int>> adjList = new List<List<int>>(n);

        for(int i=0; i< n; i++){
            adjList.Add(new List<int>());
        }

        for(int i=0; i< edges.Length; i++){
            adjList[edges[i][0]].Add(edges[i][1]);
            adjList[edges[i][1]].Add(edges[i][0]);
        }

        for(int i=0; i< adjList.Count; i++){

            if(visited[i] == false){
                visited[i] = true;
                dfs(adjList, i);
                result ++;
            }

        }

        return result;
    }

    private void dfs(List<List<int>> adjList, int i){

        List<int> nodes = adjList[i];

        foreach(int node in nodes){
            if(!visited[node]){
                visited[node] = true;
                dfs(adjList, node);
            }
        }

    } 




}