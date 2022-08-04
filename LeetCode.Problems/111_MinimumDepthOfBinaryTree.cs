namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class BinaryTreeMinimumDepth{

    public int MinDepth(TreeNode root){

        int currentDepth = 0;
        Queue<KeyValuePair<TreeNode,int>> queue = new Queue<KeyValuePair<TreeNode, int>>();      

        if (root == null){
            return currentDepth;
        }

        queue.Enqueue(new KeyValuePair<TreeNode, int>(root,1));

        while (queue.Count > 0){
            var tmp = queue.Dequeue();

            var node = tmp.Key;
            currentDepth = tmp.Value;

            if (node.left == null && node.right == null){
                break;
            }

            if (node.left != null){
                queue.Enqueue(new KeyValuePair<TreeNode, int>(node.left,currentDepth+1));
            }

            if (node.right != null){
                queue.Enqueue(new KeyValuePair<TreeNode, int>(node.right,currentDepth+1));
            }

        }

        return currentDepth;
    }

}