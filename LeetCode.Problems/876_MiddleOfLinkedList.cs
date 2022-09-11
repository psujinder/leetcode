namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class MiddleOfLinkedList {

    public ListNode MiddleNode(ListNode head) {
        
        ListNode l1 = new ListNode();
        l1 = head;

        while (head != null && head.next !=null){
           head = head.next.next;
            l1 = l1.next;
        }
        
        return l1;
    }

}