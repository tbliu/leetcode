# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution(object):
    def reverseList(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        if head is None or head.next is None:
            return head
        prev = None
        curr = head
        _next = head.next
        while (curr is not None):
            curr.next = prev
            prev = curr
            curr = _next
            if (_next != None):
                _next = _next.next
        return prev