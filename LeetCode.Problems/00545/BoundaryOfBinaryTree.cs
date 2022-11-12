namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class BoundaryOfBinaryTree{

    List<int> result = new List<int>();

    public  IList<int> BoundaryOfTree(TreeNode root) {
    
        result.Add(root.val);

        if(root.left == null && root.right == null)
            return result;

        if(root.left != null)
            //iterate to get left boundary
            IterateForLeftBoundary(root.left);

        //iterate to get leaf nodes
        if(root.left != null || root.right != null)
            IterateForLeaveNodes(root);

        if(root.right != null)
            //iterate to get right boundary
            IterateForRightBoundary(root.right);

        return result;

    }

    private void IterateForLeftBoundary(TreeNode root){

        TreeNode node = root;

        while(node!=null){

            if(node.left == null && node.right == null){
                break;
            }

            result.Add(node.val);

            if(node.left != null){
                node = node.left;
            }else if(node.right != null){
                node = node.right;
            }
        }

    }

     private void IterateForRightBoundary(TreeNode root){

        TreeNode node = root;
        Stack<int> st = new Stack<int>();


        while(node!=null){

            if(node.left == null && node.right == null){
                break;
            }

            st.Push(node.val);

            if(node.right != null){
                node = node.right;
            }else if(node.left != null){
                node = node.left;
            }
        }

        while(st.Count > 0){
            result.Add(st.Pop());
        }   
    }

    private  void IterateForLeaveNodes(TreeNode root){
        
        if(root.left == null && root.right == null){
            result.Add(root.val);
        }
        else{
            if(root.left != null){
                IterateForLeaveNodes(root.left);
            }

            if(root.right != null){
                IterateForLeaveNodes(root.right);
            }
        }
    }
    
}
