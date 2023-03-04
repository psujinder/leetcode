namespace LeetCode.Problems;
using LeetCode.Problems.Utils;

public class OddEvenLinkedList{

    public ListNode OddEvenList(ListNode head) {

        ListNode odd = head;
        ListNode even  = head.next;
        ListNode evenHead = even;
        while(even != null && even.next != null){
            odd.next = even.next;
            odd = odd.next;
            even.next = odd.next;
            even = even.next;
        }
        odd.next = evenHead;

        return head;
    } 

}