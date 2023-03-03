namespace LeetCode.Problems;

interface NestedInteger {
 
      // @return true if this NestedInteger holds a single integer, rather than a nested list.
     bool IsInteger();
 
      // @return the single integer that this NestedInteger holds, if it holds a single integer
      // Return null if this NestedInteger holds a nested list
      int GetInteger();
 
      // @return the nested list that this NestedInteger holds, if it holds a nested list
      // Return null if this NestedInteger holds a single integer
      IList<NestedInteger> GetList();
 }

public class NestedIterator {

    private List<int> flattenedList;
    private int index;

    public NestedIterator(IList<NestedInteger> nestedList) {
        
        flattenedList = new List<int>();
        index = 0;
        Flatten(nestedList);
    }

    private void Flatten(IList<NestedInteger> nestedList){
        foreach( var item in nestedList){
            if(item.IsInteger()){
                flattenedList.Add(item.GetInteger());
            }else {
                Flatten(item.GetList());
            }
        }
    }

    public bool HasNext() {
        return index < flattenedList.Count;
    }

    public int Next() {
        return flattenedList[index++];
    }
}