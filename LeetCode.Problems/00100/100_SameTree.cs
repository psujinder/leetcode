namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class SameTree {

    public bool IsSameTree(TreeNode p, TreeNode q){
        
        //check if the root nodes are the same. If the value of the nodes are not same return false.
        if (p== null && q == null){
            return true;
        }

        if (p== null && q != null || p != null && q == null || p.val != q.val){
            return false;
        }

        Queue<TreeNode> pqueue = new Queue<TreeNode>();
        Queue<TreeNode> qqueue = new Queue<TreeNode>();

        
        pqueue.Enqueue(p);
        qqueue.Enqueue(q);

        while (pqueue.Count > 0){
            var ptmp = pqueue.Dequeue();
            var qtmp = qqueue.Dequeue();

            if (ptmp == null && qtmp != null || ptmp != null && qtmp == null){
                return false;
            }

            if(ptmp != null && qtmp != null){
                if (ptmp.val != qtmp.val){
                    return false;
                }

                pqueue.Enqueue(ptmp.left);
                pqueue.Enqueue(ptmp.right);

                qqueue.Enqueue(qtmp.left);
                qqueue.Enqueue(qtmp.right);
            }            
        }

        return true;

    }

}