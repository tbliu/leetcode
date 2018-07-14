/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null) {
            return head;
        }
        var front = head.next;
        var back = head;
        while (front != null) {
            if (front.val == back.val) {
                back.next = front.next;
                front = front.next;
            } else {
                back = back.next;
                front = front.next;
            }
        }
        return head;
    }
}