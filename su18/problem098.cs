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
    public bool IsValidBST(TreeNode root) {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode curr = root;
        int lastPopped = 0;
        bool foundSmallest = false;
        while (curr != null) {
            s.Push(curr);
            curr = curr.left;
            while (curr == null && s.Count > 0) {
                curr = s.Pop();
                if (!foundSmallest) {
                    lastPopped = curr.val;
                    foundSmallest = true;
                } else if (curr.val <= lastPopped) {
                    return false;
                } else {
                    lastPopped = curr.val;
                }
                curr = curr.right;
            } 
        }
        return true;
    }
}