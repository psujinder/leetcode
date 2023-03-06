namespace LeetCode.Problems;

public class SortList_PR{

    public ListNode SortList(ListNode head) {
        
        if(head == null || head.next == null){
            return head;
        }

        ListNode slow = head;
        ListNode fast = head.next;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode mid = slow.next;
        slow.next = null;

        ListNode left = SortList(head);
        ListNode right = SortList(mid);

        return Merge(left, right);
    }

    private ListNode Merge(ListNode left, ListNode right){

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while(left != null && right != null){
            if(left.val < right.val){
                tail.next = left;
                left = left.next;
            }else{
                tail.next = right;
                right = right.next;
            }
            tail = tail.next;
        }

        if(left != null){
            tail.next = left;
        }

        if(right != null){
            tail.next = right;
        }

        return dummy.next;

    }

}


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}