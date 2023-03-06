namespace LeetCode.Problems;

public class CopyListWithRandomPointer{

    public Node CopyRandomList(Node head) {

        if (head == null) {
            return null;
        }

        Dictionary<Node,Node> map = new Dictionary<Node, Node>();
        
        Node node = head;

        while(node!= null){
            Node clone = new Node(node.val);
            map.Add(node,clone);
            node = node.next;
        }

        node = head;

        while(node != null){
            if(node.next != null)
                map[node].next = map[node.next];
            
            if(node.random != null)
                map[node].random = map[node.random];

            node = node.next;
        }

        return map[head];
    }

}

public class Node {
    public int val;
    public Node next;
    public Node random;
    public List<Node> children;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}