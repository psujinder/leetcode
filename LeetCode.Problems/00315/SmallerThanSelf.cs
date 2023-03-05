namespace LeetCode.Problems;

public class SmallerThanSelf{

    public IList<int> CountSmaller(int[] nums) {
        
        int n = nums.Length;
        int[] result = new int[n];
        BSTNode root = null;

        for(int i=0; i<n;i++){
            root = InsertNode(root, nums[i],i, result);
        }

        return result;
    }

    private BSTNode InsertNode(BSTNode node, int val, int index, int[] result){

        if(node == null){
            return new BSTNode(){Value=val, Index=index};
        }
        else if (val <= node.Value){
            node.Count++;
            node.Left = InsertNode(node.Left,val,index,result);
        }else{
            result[index] += node.Count;
            node.Right = InsertNode(node.Right,val,index,result);
        }

        return node;
    }
}

public class BSTNode{

    public int Value {get; set;}
    public int Index {get;set;}
    public int Count {get; set;}
    public BSTNode Left {get;set;}
     public BSTNode Right {get;set;}
}