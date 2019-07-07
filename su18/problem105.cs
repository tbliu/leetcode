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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder == null || inorder == null) {
            return null;
        }
        if (preorder.Length == 0 || inorder.Length == null) {
            return null;
        }
        return Helper(preorder, inorder, 0, 0, inorder.Length - 1);
    }

    private TreeNode Helper(int[] preorder, int[] inorder, int pStart, int iStart, int iEnd) {
        if (pStart > preorder.Length - 1 || iStart > iEnd) {
            return null;
        }
        TreeNode node = new TreeNode(preorder[pStart]);
        int idx = 0;
        for (int i = 0; i < inorder.Length; i++) {
            if (inorder[i] == preorder[pStart]) {
                idx = i;
                break;
            }
        }
        node.left = Helper(preorder, inorder, pStart + 1, iStart, idx - 1);
        node.right = Helper(preorder, inorder, idx + 1, iEnd);
        return node;
    }
}