/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return Traverse(root, 0);
    }

    private bool IsLeaf(TreeNode node) {
        return node.left == null && node.right == null;
    }

    /* movedLeft == 1 if we went left to get to this node, 0 if we went right */
    private int Traverse(TreeNode node, int movedLeft) {
        if (node == null) {
            return 0;
        } else if (IsLeaf(node) && movedLeft == 1) {
            return node.val;
        } else if (IsLeaf(node) && movedLeft == 0) {
            return 0;
        } else {
            return Traverse(node.left, 1) + Traverse(node.right, 0);
        }
    }
}