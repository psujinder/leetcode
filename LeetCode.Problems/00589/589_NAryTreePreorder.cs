namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class NAryPreOrderTreeOrder{
    
    List<int> order = new List<int>();

    public IList<int> Preorder(Node root){

        List<int> order = new List<int>();

        if(root == null){
            return null;
        }

        order.Add(root.val);
        foreach(Node node in root.children){
            AddNode(node);
        }

        return order;
    }

    public void AddNode(Node node){
        order.Add(node.val);
        foreach(Node n in node.children){
            AddNode(n);
        }
    }

}