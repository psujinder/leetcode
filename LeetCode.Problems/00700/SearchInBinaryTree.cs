namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class SearchInBinaryTree{

    public TreeNode SearchBST(TreeNode root, int val) {
        
        TreeNode node = root;

        while(node != null && node.val != val){
            node = (val > node.val)? node.left: node.right;
        }

        return node;
    }
}