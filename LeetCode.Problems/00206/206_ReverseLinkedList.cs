namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class ReverseLinkedList{

    public ListNode ReverseList(ListNode head) {

        ListNode prev = null;
        ListNode curr = head;

        while(curr != null){
            ListNode tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        return prev;
    }

    public ListNode Reverse(ListNode head){

        ListNode prev = null;
        ListNode curr = head;

        while(curr != null){
            var tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        return prev;
    }



}