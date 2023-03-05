namespace LeetCode.Problems;

public class SmallerThanSelf{

    public IList<int> CountSmaller(int[] nums) {
        
       List<int> result = new List<int>();
       if(nums == null || nums.Length == 0){
           return result;
       } 
       
       BSTNode root = new BSTNode(nums[nums.Length-1]);
       result.Add(0);

       for(int i= nums.Length-2; i >=0; i--){
           int count = InsertNode(root, nums[i]);
           result.Add(count);
       }

       result.Reverse();
       return result;
    }

    //build BST Tree
    private int InsertNode(BSTNode root, int i){
        int small = 0;
        BSTNode tmp = new BSTNode(i);
        bool isConnect = false;
        while(!isConnect){
            if(tmp.data <= root.data){
                root.count ++;
                if(root.left != null){
                    root = root.left;
                }else{
                    root.left = tmp;
                    isConnect = true;
                }
            }else{
                small += root.count;
                if(root.right == null){
                    root.right = tmp;
                    isConnect = true;
                }else{
                    root = root.right;
                }
            }
        }
        return small;
    }
}

public class BSTNode{
    public BSTNode left {get;set;}
    public BSTNode right {get;set;}
    public int data {get;set;}
    public int count = 1;

    public BSTNode(int data){
        this.data = data;
    }

}