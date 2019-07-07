/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode sentinel = new ListNode(0);
        ListNode curr1 = l1;
        ListNode curr2 = l2;
        ListNode curr = sentinel;
        while (curr1 != null && curr2 != null) {
            if (curr1.val <= curr2.val) {
                curr.next = curr1;
                curr = curr.next;
                curr1 = curr1.next;
            } else {
                curr.next = curr2;
                curr = curr.next;
                curr2 = curr2.next;
            }
        }
        while (curr1 != null) {
            curr.next = curr1;
            curr = curr.next;
            curr1 = curr1.next;
        }
        while (curr2 != null) {
            curr.next = curr2;
            curr = curr.next;
            curr2 = curr2.next;
        }
        return sentinel.next;
    }
}