# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution(object):
    def inorderTraversal(self, root):
        """
        :type root: TreeNode
        :rtype: List[int]
        """
        if root == None:
            return []
        stack = [root]
        order = []
        curr = root
        while len(stack) > 0:
            curr = curr.left
            while curr == None:
                if len(stack) == 0:
                    return order
                curr = stack.pop()
                order.append(curr.val)
                curr = curr.right
            stack.append(curr)
        return order
            
