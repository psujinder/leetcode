// See https://aka.ms/new-console-template for more information
using LeetCode.Problems;
using LeetCode.Problems.Utils;
using System.Globalization;


ListNode n1 = new ListNode(1);
/*n1.next = new ListNode(2);
n1.next.next = new ListNode(3);
n1.next.next.next = new ListNode(4);
n1.next.next.next.next = new ListNode(5);*/

RemoveNthNodeFromEndOfList sol = new RemoveNthNodeFromEndOfList();
sol.RemoveNthFromEnd(n1,1);