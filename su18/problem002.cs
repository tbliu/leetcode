/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode curr1 = l1;
        ListNode curr2 = l2;
        int carry = 0;
        while (curr1 != null || curr2 != null) {
            int val1 = (curr1 != null) ? curr1.val : 0;
            int val2 = (curr2 != null) ? curr2.val : 0;
            int val = val1 + val2 + carry;
            carry = val / 10;
            val %= 10;
            if (curr1.next == null && curr2 != null && curr2.next != null) {
                curr1.next = new ListNode(0);
            }
            if (carry > 0 && curr1.next == null) {
                curr1.next = new ListNode(0);
            }
            curr1.val = val;
            curr1 = curr1.next;
            curr2 = (curr2 == null) ? curr2 : curr2.next;
        }
        return l1;
    }
}