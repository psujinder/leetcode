namespace LeetCode.Problems;

using LeetCode.Problems.Utils;


public class BinaryTreeDiameter {

    private int diamter = 0;

    public int DiameterOfBinaryTree (TreeNode root){

        Diameter(root);
        return diamter;

    }


     public int Diameter(TreeNode root){

            if(root == null){
                return 0;
            }

            int leftheight = Diameter(root.left);
            int rightheight = Diameter(root.right);

            diamter = Math.Max(diamter, leftheight + rightheight);
            
            return Math.Max(leftheight,rightheight) + 1;

    }

}