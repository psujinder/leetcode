namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class RemoveNthNodeFromEndOfList{
    public ListNode RemoveNthFromEnd(ListNode head, int n){

        ListNode p1 = head;
        ListNode p2 = head;

        for(int i=0; i< n; i++){
            p1 = p1.next;
        }

        if(p1 == null){
            return head.next;
        }

        while(p1.next != null){
            p1 = p1.next;
            p2 = p2.next;
        }

        p2.next = p2.next.next;

        return head;
    }
}