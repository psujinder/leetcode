namespace LeetCode.Problems;

/*
public class NestedIterator2 {

    private Stack<IEnumerator<NestedInteger>> stack;


    public NestedIterator2(IList<NestedInteger> nestedList) {
        
        stack = new Stack<IEnumerator<NestedInteger>>();
        stack.Push(nestedList.GetEnumerator());
    }

    public bool HasNext() {
        
        while(stack.Count >0){
            var enumerator = stack.Peek();
            if(!enumerator.MoveNext()){
                stack.Pop();
            }else{
                var item = enumerator.Current;
                if(item.IsInteger()){
                    return true;
                }else{
                    stack.Push(item.GetList().GetEnumerator());
                }
            }
        }

        return false;
    }

    public int Next() {
        
        var enumerator = stack.Peek();
        var item = enumerator.Current;
        enumerator.MoveNext();
        if(!enumerator.MoveNext()){
            stack.Pop();
        }
        
        return item.GetInteger();

    }
} */