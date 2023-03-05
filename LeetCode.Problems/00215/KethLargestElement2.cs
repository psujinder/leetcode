namespace LeetCode.Problems;

public class KthLargestElement2{

    public int FindKthLargest(int[] nums, int k) {

        PriorityQueue<int> pq = new PriorityQueue<int>();
        
        foreach(int num in nums){
            
            pq.Enqueue(num);
            if(pq.Count() > k){
                pq.Dequeue();
            }
        }

        return pq.Peek();

    }

}