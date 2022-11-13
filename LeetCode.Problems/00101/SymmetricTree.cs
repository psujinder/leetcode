namespace LeetCode.Problems;
using System.Collections.Generic;
using LeetCode.Problems.Utils;

public class SymmetricTree {

    public bool IsSymmetric(TreeNode root) {
        

        Queue<TreeNode> queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        queue.Enqueue(root);

        while(queue.Count > 0){
            TreeNode node1 = queue.Dequeue();
            TreeNode node2 = queue.Dequeue();

            if(node1 == null && node2 == null){
                continue;
            }

            if(node1 == null || node2 == null){
                return false;
            }

            if(node1.val != node2.val){
                return false;
            }

            queue.Enqueue(node1.left);
            queue.Enqueue(node2.right);
            queue.Enqueue(node1.right);
            queue.Enqueue(node2.left);
        }

        return true;

    }

}