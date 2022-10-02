namespace LeetCode.Problems;

public class NumberofProvinces{
    public int FindCircleNum(int[][] isConnected) {
        
        int[] visited = new int[isConnected.Length];
        int count = 0;
        Queue<int> queue = new Queue<int>();
        
        for(int i=0; i< isConnected.Length; i++){
            if(visited[i] == 0){
                queue.Enqueue(i);
                while(queue.Count != 0){
                    int s = queue.Dequeue();
                    visited[s] = 1;
                    for(int j=0; j< isConnected.Length; j++){
                        if(isConnected[s][j] == 1 && visited[j]==0){
                            queue.Enqueue(j);
                        }
                    }
                }
                count ++;
            }
        }
        
        return count;
    }
    
}