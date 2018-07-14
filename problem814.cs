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
    public TreeNode PruneTree(TreeNode root) {
        if (root == null) {
            return root;
        }

        if (!ContainsOne(root.left)) {
            root.left = null;
        }

        if (!ContainsOne(root.right)) {
            root.right = null;
        }

        PruneTree(root.left);
        PruneTree(root.right);
        return root;
    }

    private bool ContainsOne(TreeNode node) {
        if (node == null) {
            return false;
        }
        if (node.val == 1) {
            return true;
        }
        return ContainsOne(node.left) || ContainsOne(node.right);
    }
}