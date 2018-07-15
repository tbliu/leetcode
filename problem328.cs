/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode evenHead = head.next;
        ListNode currOdd = head;
        ListNode currEven = head.next;
        while (currOdd != null && currEven != null && currOdd.next != null && currEven.next != null) {
            currOdd.next = currEven.next;
            currOdd = currOdd.next;
            currEven.next = currOdd.next;
            currEven = currEven.next;
        }
        currOdd.next = evenHead;
        return head;
    }
}