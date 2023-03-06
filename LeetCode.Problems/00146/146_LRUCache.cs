namespace LeetCode.Problems;

using System.Collections.Specialized;

public class LRUCache {

    private int capacity;
    private LinkedList<KeyValuePair<int, int>> list;
    private Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        list = new LinkedList<KeyValuePair<int, int>>();
        map = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();
    }

    public int Capacity{
        get {return this.capacity;}
    }
    
    public int Get(int key) {
        
        if(!map.ContainsKey(key)){
            return -1;
        }

        LinkedListNode<KeyValuePair<int, int>> node = map[key];
        list.Remove(node);
        list.AddFirst(node);
        return node.Value.Value;
    
    }
    
    public void Put(int key, int value) {

        if(map.ContainsKey(key)){
            LinkedListNode<KeyValuePair<int,int>> node = map[key];
            list.Remove(node);
            node.Value = new KeyValuePair<int, int>(key, value);
            list.AddFirst(node);
        }else{
            if(map.Count == capacity){
                LinkedListNode<KeyValuePair<int,int>> last = list.Last;
                list.RemoveLast();
                map.Remove(last.Value.Key);
            }
            LinkedListNode<KeyValuePair<int,int>> node = new LinkedListNode<KeyValuePair<int, int>>(new KeyValuePair<int, int>(key,value));
            list.AddFirst(node);
            map.Add(key, node);

        }
        
    }


}