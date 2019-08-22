# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution(object):
    def oddEvenList(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        if head is None:
            return None
        oddStart = odds = head
        evenStart = evens = head.next
        while odds != None and evens != None:
            odds.next = evens.next
            if odds.next is not None:
                odds = odds.next
            evens.next = odds.next
            evens = evens.next
            
        odds.next = evenStart
        return oddStart