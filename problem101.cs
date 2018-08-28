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
    public bool IsSymmetric(TreeNode root) {
        if (root == null) {
            return true;
        }
        return IsSymmetricHelper(root.left, root.right);
    }

    private bool IsSymmetricHelper(TreeNode node1, TreeNode node2) {
        if (node1 == null && node2 == null) {
            return true;
        } else if (node1 == null || node2 == null) {
            return false;
        }

        return node1.val == node2.val 
            && IsSymmetricHelper(node1.left, node2.right)
            && IsSymmetricHelper(node1.right, node2.left);
    }
}