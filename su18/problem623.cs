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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if (d == 1) {
            TreeNode newRoot = new TreeNode(v);
            newRoot.left = root;
            return newRoot;
        }

        TreeHelper(root, v, d);
        return root;
    }

    private void TreeHelper(TreeNode node, int v, int d) {
        if (node == null) {
            return;
        }

        if (d - 1 == 1) {
            TreeNode originalLeft = node.left;
            TreeNode originalRight = node.right;

            TreeNode newLeft = new TreeNode(v);
            newLeft.left = originalLeft;
            node.left = newLeft;
            
            TreeNode newRight = new TreeNode(v);
            newRight.right = originalRight;
            node.right = newRight;
            
            return;
        }

        TreeHelper(node.left, v, d - 1);
        TreeHelper(node.right, v, d - 1);
        return;
    }
}