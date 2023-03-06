namespace LeetCode.Problems;

public class DeleteNodeLinkedList{

    public void DeleteNode(ListNode node) {
        
        if(node == null){
            return;
        }

        node.val = node.next.val;
        node.next = node.next.next;
        
    }

}