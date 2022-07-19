namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class BinaryTreeDepth {

    public int MaxDepth(TreeNode root){

            if(root == null){
                return 0;
            }

            int leftheight = MaxDepth(root.left);
            int rightheight = MaxDepth(root.right);

            return Math.Max(leftheight,rightheight) + 1;

    }

}