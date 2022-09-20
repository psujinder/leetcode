namespace LeetCode.Problems;

using LeetCode.Problems.Utils;

public class MergeSortedLists{

    public ListNode MergedLists(ListNode list1, ListNode list2){

        ListNode mergedHead = new ListNode(-1);
        ListNode mergedNode = mergedHead;

        while(list1!= null && list2 != null){

            mergedNode.next = new ListNode();
            mergedNode = mergedNode.next;
            if(list1.val < list2.val){
                mergedNode.val = list1.val;
                list1 = list1.next;
            }else{
                mergedNode.val = list2.val;
                list2 = list2.next;
            }
        }

        mergedNode.next = (list1 == null)? list1 : list2;

        return mergedHead;

    }

}