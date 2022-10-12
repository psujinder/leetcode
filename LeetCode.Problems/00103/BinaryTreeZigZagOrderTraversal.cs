namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class BinaryTreeZigZagOrderTraversal{

    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> items = new List<IList<int>>();
        
        if(root == null){
            return items;
        }

        LinkedList<int> re = new LinkedList<int>();
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        bool lToR = true;
        int levelItemsCount = 0;

        queue.Enqueue(root);

        while(queue.Count > 0){

            List<int> levelItems = new List<int>();  
            levelItemsCount = queue.Count; 
            for(int i = 0; i < levelItemsCount; i++){
                TreeNode tmp = queue.Dequeue();
                levelItems.Add(tmp.val);

                if(tmp.left!=null)
                    queue.Enqueue(tmp.left);
                
                if(tmp.right!=null)
                    queue.Enqueue(tmp.right);
            }    

            if(!lToR)
                levelItems.Reverse();

            items.Add(levelItems);
            lToR = !lToR;
                
        }   
        
        return items;
    }

}