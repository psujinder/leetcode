namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class AllNodesDistanceKInBinaryTree{

    List<int> result = new List<int>();
    

    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {

        if(root == null){
            return result;
        }

        if(root.left == null && root.right == null){
            return result;
        }

        dfs(root,target,k);

        return result;
    }

    private int dfs(TreeNode node, TreeNode target, int k){

        if(node == null){
            return -1;
        }else if (node.val == target.val){
            subtree(node, 0, k);
            return 1;
        }else{

            int left = dfs(node.left, target, k);
            int right = dfs(node.right, target, k);

            if(left != -1){
                if(left == k)
                    result.Add(node.val);
                subtree(node.right, left+1, k);
                return left+1;
            }else if(right != -1){
                 if(right == k)
                    result.Add(node.val);
                subtree(node.left, right+1, k);
                return right+1;
            }else {
                return -1;
            }

        }
    }

    private void subtree(TreeNode node, int currentLevel, int k){

        if(node == null){
            return;
        }

        if(currentLevel == k){
            result.Add(node.val);
        }else{
            if(node.left != null){
                subtree(node.left, currentLevel+1, k);
            }

            if(node.right != null){
                subtree(node.right, currentLevel+1, k);
            }

        }

    }

}