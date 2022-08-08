namespace LeetCode.Problems.Utils;

public class TreeNode{
    public int val;
    public TreeNode left;
    public TreeNode right;
   

    public TreeNode( int val = 0, TreeNode left = null, TreeNode right = null){
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Tree {

    private TreeNode _root;

    
    public Tree(){
        _root = null;
    }

    public Tree(TreeNode node){
        _root = node;
    }

    public void AddNode(TreeNode nodeToAdd, TreeNode parent){

        var node = _root;
        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(node);

        while (node.val != parent.val){
            node = queue.Dequeue();

            if(node.left != null){
                queue.Enqueue(node.left);
            } 

            if(node.right != null){
                queue.Enqueue(node.right);
            }    
        }

        if(node.left == null){
            node.left = nodeToAdd;
        }else {
            node.right = nodeToAdd;
        }


    }

}