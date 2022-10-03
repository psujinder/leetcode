namespace LeetCode.Problems;

public class EventualSafeStates{

    public IList<int> EventualSafeNodes(int[][] graph) {
        
        Dictionary<int, bool> safeNodes = new  Dictionary<int, bool>();
        List<int> visited = new List<int>();

        //determine the terminal nodes
        for(int i=0; i< graph.Length; i++){
            if(graph[i].Length == 0){
                safeNodes.Add(i, true);
            }
        }

        for(int i=0; i< graph.Length; i++){
            bool result = dfs(graph, i, visited, safeNodes);
            if(!safeNodes.ContainsKey(i)){
                safeNodes.Add(i, result);
            }else{
                safeNodes[i] = result;
            }
            
        }

        List<int> results = new List<int>();

        for(int i=0; i < graph.Length; i++){
            if(safeNodes[i]){
                results.Add(i);
            }
        }

        return results;
    }

    private bool dfs(int[][] graph, int i, List<int> visited, Dictionary<int, bool> safeNodes){

        if(safeNodes.ContainsKey(i)){
            return safeNodes[i];
        }
        
        if (visited.Contains(i)){
            return false;
        }

        visited.Add(i);

        foreach(int node in graph[i]){
            if(dfs(graph, node, visited, safeNodes)){
                if(!safeNodes.ContainsKey(node)){
                    safeNodes.Add(node, true);
                }
            }else{
                return false;
            }
        }

        visited.Remove(i);
    
        return true;
    }
}