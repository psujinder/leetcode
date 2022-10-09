namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class LinkedLisCycle{
    public bool HasCycle(ListNode head) {

        if(head == null || head.next == null){
            return false;
        }

        ListNode firstPntr = head.next, secondPtr = head;

        while(firstPntr!= secondPtr){
            if(firstPntr== null || firstPntr.next == null){
                return false;
            }
            secondPtr = secondPtr.next;
            firstPntr = firstPntr.next.next;
        }
       
        return true;
    }
}