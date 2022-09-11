namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class ReverseLinkedList{

    public ListNode ReverseList(ListNode head) {

        /*ListNode prev = null;
        ListNode curr = head;

        while(curr != null){
            ListNode tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        return prev;*/

        if(head == null || head.next == null){
            return head;
        }

        ListNode p = ReverseList(head.next);
        head.next.next = head;
        head.next = null;

        return p;
    }

}