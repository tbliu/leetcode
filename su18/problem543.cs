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
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) {
            return 0;
        }
        if (root.left == null && root.right == null) {
            return 0;
        }
        return Math.Max(
            Math.Max(DiameterOfBinaryTree(root.left),
            DiameterOfBinaryTree(root.right)),
            // Need to double count the root for each side's height
            1 + GetHeight(root.left) + 1 + GetHeight(root.right)
        );
    }

    private int GetHeight(TreeNode node) {
        if (node == null) {
            return -1;
        }
        return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }
}