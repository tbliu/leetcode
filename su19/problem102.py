# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution(object):
    def levelOrder(self, root):
        """
        :type root: TreeNode
        :rtype: List[List[int]]
        """
        order = []
        level = [root]
        while len(level) > 0:
            nextLevel = []
            levelToAdd = [elem.val for elem in level if elem is not None]
            if levelToAdd != []:
                order.append([elem.val for elem in level if elem is not None])
            for elem in level:
                if elem is None:
                    continue
                if elem.left is not None:
                    nextLevel.append(elem.left)
                if elem.right is not None:
                    nextLevel.append(elem.right)
            level = nextLevel
        return order