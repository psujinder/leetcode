namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class LinkedListCycleTwo {

    public ListNode DetectCycle(ListNode head){

        List<ListNode> visited = new List<ListNode>();

        while(head != null){
            if (visited.Contains(head)){
                return head;
            }

            visited.Add(head);
            head = head.next;
        }

        return null;
    }

}