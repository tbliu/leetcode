/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if (head == null) {
            return true;
        }
        Stack<int> values = new Stack<int>();
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null) {
            if (fast.next == null) {
                fast = fast.next;
            } else {
                fast = fast.next.next;
                values.Push(slow.val);
            }
            slow = slow.next;

        }
        while (slow != null) {
            if (slow.val != values.Pop()) {
                return false;
            }
            slow = slow.next;
        }
        return values.Count() == 0;
    }
}