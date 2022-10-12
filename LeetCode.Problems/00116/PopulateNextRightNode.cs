namespace LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Collections.Generic;

public class PopulateNextRightNode{

    public Node Connect(Node root) {
        

        Queue<Node> queue = new Queue<Node>();
        Queue<Node> levelNodes = new Queue<Node>();

        queue.Enqueue(root);

        while(queue.Count >0){
            int levelNodeCount = queue.Count;
        }

        return root;

    }

}