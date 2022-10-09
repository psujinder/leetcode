namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class AddTwoNumbers{

    public ListNode AddTwoNums(ListNode l1, ListNode l2) {
        
        ListNode head = new ListNode(0);
        ListNode curr = head;

        int carryOver = 0;
        while( l1 != null || l2 != null || carryOver!=0){
            int tmp1 = (l1 != null)? l1.val:0;
            int tmp2 = (l2 != null)? l2.val:0;

            int tmpSum = tmp1+tmp2+carryOver;
            carryOver = tmpSum / 10;
            curr.next = new ListNode(tmpSum % 10);
            curr = curr.next;

            if(l1!= null){
                l1 = l1.next;
            }
            if(l2!= null){
                l2 = l2.next;
            }
        }
        return head.next;
    }
}