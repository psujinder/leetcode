namespace LeetCode.Problems;

public class CheapestFlightsWithinKStops{

    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        
        int answer = Int32.MaxValue;
        Dictionary<KeyValuePair<int,int>, int> results = new Dictionary<KeyValuePair<int, int>, int>();

        //build the adjacency matrix
        int[][] adjMatrix = new int[n][];
        for(int i=0; i < n; i++){
            adjMatrix[i] = new int[n];
        }

        foreach(int[] flight in flights){
            adjMatrix[flight[0]][flight[1]] = flight[2];
        }

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(src);

        int stops = 0;

        while (queue.Count !=0 && stops < k+1 ){
            
            int length = queue.Count;

            for(int i=0; i < length; i++){

                int curr = queue.Dequeue();

                for(int j =0 ;j < n; ++j){
                    
                    if(adjMatrix[curr][j] >0){
                        
                        int currCost = results.GetValueOrDefault(new KeyValuePair<int, int>(curr,stops), 0);
                        int tmpCost = results.GetValueOrDefault(new KeyValuePair<int, int>(j,stops), 0);
                        int cost = adjMatrix[curr][j];
                        
                        if(stops == k && j != dst){
                            continue;
                        }

                        if(results.ContainsKey(new KeyValuePair<int, int>(j, stops+1))){
                            results[new KeyValuePair<int, int>(j, stops+1)]= currCost+cost;
                        }else{
                            results.Add(new KeyValuePair<int, int>(j, stops+1), currCost+cost);
                        }
                        queue.Enqueue(j);
                        if(j == dst){
                                answer = Math.Min(answer, currCost+cost);
                        }
                        
            
                    }
                }
            }
            stops ++;
        }


        return answer == Int32.MaxValue? -1 : answer;

    }

}