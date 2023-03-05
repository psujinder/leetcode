namespace LeetCode.Problems;

public class PriorityQueue<T> where T: IComparable<T>{

    private List<T> heap;

    public PriorityQueue(){
        heap = new List<T>();
    }

    public void Enqueue(T item){
        heap.Add(item);

        int i = heap.Count - 1;

        while (i>0){
            int parent = (i-1)/2;

            if(heap[parent].CompareTo(heap[i]) <0){
                break;
            }

            T temp = heap[parent];
            heap[parent] = heap[i];
            heap[i] = temp;
            i = parent;
        }
    }

    public T Dequeue(){
        T item = heap[0];
        int n = heap.Count - 1;
        heap[0] = heap[n];
        heap.RemoveAt(n);
        n--;

        int i=0;

        while (true){
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            int smallest = i;

            if (left <=n && heap[left].CompareTo(heap[smallest]) <=0){
                smallest = left;
            }

            if(right <=n && heap[right].CompareTo(heap[smallest]) <=0){
                smallest = right;
            }

            if(smallest == i){
                break;
            }

            T temp = heap[smallest];
            heap[smallest] = heap[i];
            heap[i] = temp;
            i = smallest;
        }

        return item;
    }

    public int Count(){
        return heap.Count();
    }

    public T Peek(){
        return heap[0];
    }

}