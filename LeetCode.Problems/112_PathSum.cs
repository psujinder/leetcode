namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class PathSum {

    public bool HasPathSum(TreeNode root, int targetSum){

       if(root == null){
            return false;
       }

       targetSum -= root.val;

       if(root.left == null && root.right == null){
            return (targetSum == 0);
       }

       return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);ß
    }

}