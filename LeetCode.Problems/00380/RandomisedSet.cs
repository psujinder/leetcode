namespace LeetCode.Problems;

public class RandomizedSet {

    private List<int> nums;
    private Dictionary<int, int> indexMap;
    private Random rand;

    public RandomizedSet() {
        nums = new List<int>();
        indexMap = new Dictionary<int, int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {

        if (indexMap.ContainsKey(val)) {
            return false;
        }
        nums.Add(val);
        indexMap[val] = nums.Count - 1;
        return true;
    }
    
    public bool Remove(int val) {

        if (!indexMap.ContainsKey(val)) {
            return false;
        }
        int index = indexMap[val];
        int last = nums[nums.Count - 1];
        nums[index] = last;
        indexMap[last] = index;
        nums.RemoveAt(nums.Count - 1);
        indexMap.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        
        int index = rand.Next(nums.Count);
        return nums[index];
        
    }
}