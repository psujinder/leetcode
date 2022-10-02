namespace LeetCode.Problems;

public class GraphValidTree{

    public bool ValidTree(int n, int[][] edges) {

        //construct adjacency list
        List<List<int>> lst = new List<List<int>>(1);

        for(int i=0; i< n; i++){
            lst.Add(new List<int>());
        }

        for(int i=0; i< edges.Length; i++){
            lst[edges[i][0]].Add(edges[i][1]);
            lst[edges[i][1]].Add(edges[i][0]);
        }

        List<int> visited = new List<int>();
        visited.Add(0);

        Stack<int> stack = new Stack<int>();
        stack.Push(0);
        

        while(stack.Count != 0){
            var node = stack.Pop();
            foreach(int i in lst[node]){
                if(!visited.Contains(i)){
                    stack.Push(i);
                    visited.Add(i);
                    lst[i].Remove(node);
                }else{
                    return false;
                }
            }
        }

        return visited.Count == n;
    }

}