namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class ValidateBinarySearchTree{

    public bool IsValidBST(TreeNode root){
        return IsNodeValid(root, null, null);
    }

    private bool IsNodeValid(TreeNode node, int? low, int? high){

         if (node == null)
            return true;

        if ((low != null && node.val <= low) || (high!= null && node.val >= high)){
            return false;
        }
        
        return IsNodeValid(node.right,node.val,high) && IsNodeValid(node.left, low, node.val);
    }

}