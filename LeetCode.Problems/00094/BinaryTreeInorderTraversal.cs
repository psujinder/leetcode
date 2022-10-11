namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class BinaryTreeInorderTraversal{

    public IList<int> InorderTraversal(TreeNode root) {
        List<int> nodes = new List<int>();
        traversal(root, nodes);
        return nodes;
    }

    private void traversal(TreeNode root, List<int> nodes){
        
        if(root==null){
            return;
        }

        traversal(root.left, nodes);
        nodes.Add(root.val);
        traversal(root.right, nodes);
    }

}