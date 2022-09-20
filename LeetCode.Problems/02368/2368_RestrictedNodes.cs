namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class MaxReachableNodesWithRestriction{

    Dictionary<int,List<int>> graph = new Dictionary<int, List<int>>();
    bool[] visitedNodes;

    public int MaxNodes(int n, int[][] edges, int[] restricted){

        //build graph
        BuildGraph(edges);
        visitedNodes = new bool[n];
        foreach(int i in restricted){
            visitedNodes[i] = true;
        }

        if(visitedNodes[0]){
            return 0;
        }

        //dfs traversal
        int maxNodes = DFSTraversal(0);

        return maxNodes;
    }

     private void BuildGraph(int[][] edges){
            
        for(int i = 0; i < edges.Length ; i++){
            
            if(!graph.ContainsKey(edges[i][0]))
                graph.Add(edges[i][0], new List<int>());
            
            if(!graph.ContainsKey(edges[i][1]))
                graph.Add(edges[i][1], new List<int>());
            
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);

            /*if(graph.ContainsKey(edges[i][0])){
                graph[edges[i][0]].Add(edges[i][1]);
            }else{
                graph.Add(edges[i][0], new List<int>(edges[i][1]));
            }*/
            
        }
    }

    private int DFSTraversal(int node){
       int maxNodes =1;
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(node);
        visitedNodes[node] = true;
        
        while(queue.Count > 0){
            var tmpNode = queue.Dequeue();

            foreach(int route in graph[tmpNode]){
                if(!visitedNodes[route]){
                    visitedNodes[route] = true;
                    queue.Enqueue(route);
                    maxNodes++;
                }
            }
            
        }

        return maxNodes;
    }

}