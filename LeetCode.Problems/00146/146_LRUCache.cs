namespace LeetCode.Problems;

using System.Collections.Specialized;

public class LRUCache {

    private int _capacity;
    private OrderedDictionary _dict = new OrderedDictionary();

    public LRUCache(int capacity) {
        this._capacity = capacity;
    }

    public int Capacity{
        get {return _capacity;}
    }
    
    public int Get(int key) {
        
        if(_dict.Contains(key.ToString())){
            var value = _dict[key.ToString()];
            _dict.Remove(key.ToString());
            _dict.Insert(0, key.ToString(), value);
            return Int32.Parse(value.ToString());
        }else{
            return -1;
        }
        
    }
    
    public void Put(int key, int value) {

        if(_dict.Contains(key.ToString())){
            _dict.Remove(key.ToString());
            _dict.Insert(0, key.ToString(), value);
        }else{
             _dict.Insert(0, key.ToString(), value);
        }

        if(_dict.Count > _capacity){
            _dict.RemoveAt(_dict.Count-1);
        }
    }


}