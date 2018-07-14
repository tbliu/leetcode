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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> order = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode node = root;
        while (node != null) {
            stack.Push(node);
            node = node.left;
            while (node is null && stack.Count > 0) {
                node = stack.Pop();
                order.Add(node.val);
                node = node.right;
            }
        }
        return order;
    }
}