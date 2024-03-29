namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class BinaryLevelOrderTraversal{

    public IList<IList<int>> LevelOrder(TreeNode root){

        List<IList<int>> items = new List<IList<int>>();
        
        if(root == null){
            return items;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
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

            items.Add(levelItems);
        }   
        
        return items;
    }

}