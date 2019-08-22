# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution(object):
    def deleteNode(self, node):
        """
        :type node: ListNode
        :rtype: void Do not return anything, modify node in-place instead.
        """
        if node is None:
            return
        tail = node.next
        while tail is not None:
            node.val = tail.val
            if tail.next is None:
                node.next = None
            node = tail
            tail = tail.next
        return
