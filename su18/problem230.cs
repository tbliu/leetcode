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
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode node = root;
        while (node != null) {
            s.Push(node);
            node = node.left;
            while (node == null && s.Count() > 0) {
                node = s.Pop();
                if (node != null) {
                    k -= 1;
                    if (k == 0) {
                        return node.val;
                    }
                    node = node.right;
                }
            }
        }
        return -1;
    }
}