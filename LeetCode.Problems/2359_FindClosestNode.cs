namespace LeetCode.Problems;

public class FindClosestNodeToGivenTwoNodes{


    Dictionary<int, int> graph = new Dictionary<int, int>();

    public  int ClosestMeetingNodes(int[] edges, int node1 , int node2){

            //build the class
            BuildGraph(edges);

            int[] distance1 = new int[edges.Length];
            int[] distance2 = new int[edges.Length];

            distance1 = bfs(node1);
            distance2 = bfs(node2);

            int[] maxDistance = new int[distance1.Length];
            Array.Fill(maxDistance,-1);

            for(int i =0; i < distance1.Length; i++){
                    if(distance1[i] >= 0 && distance2[i] >= 0){
                        maxDistance[i] = Math.Max(distance1[i], distance2[i]);
                    }

            }

            int nodeIndex = -1;
            int minValue = int.MaxValue;

            for(int i = 0; i <maxDistance.Length; i++){
                if(maxDistance[i] < minValue && maxDistance[i] > -1){
                    nodeIndex = i;
                    minValue = maxDistance[i];
                }
            }

            if (minValue == int.MaxValue)
                return -1;
            else
                return nodeIndex;

    }

    private void BuildGraph(int[] edges){
            
        for(int i = 0; i < edges.Length ; i++){
            graph.Add(i, edges[i]);
        }
    }

    private int[] bfs(int node){

        int[] dist = new int[graph.Count];
        bool[] visited = new bool[graph.Count];
        Array.Fill(dist, -1);
        int distance = 0;
        dist[node] = distance;

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(node);

        while(queue.Count > 0){
            var next = queue.Dequeue();

            if (next == -1 || visited[next]){
                break;
            }
            visited[next] = true;
            distance ++;
            dist[next] = distance;
            queue.Enqueue(graph[next]);
        }

        return dist;      

    }

}