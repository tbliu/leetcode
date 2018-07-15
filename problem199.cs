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
    public IList<int> RightSideView(TreeNode root) {
        IList<int> depthValues = new List<int>();
        Helper(root, depthValues, 0);
        return depthValues;
    }

    private void Helper(TreeNode node, IList<int> depthValues, int depth) {
        if (node == null) {
            return;
        }
        if (depthValues.Count() - 1 < depth) {
            depthValues.Add(node.val);
        }
        Helper(node.right, depthValues, depth + 1);
        Helper(node.left, depthValues, depth + 1);
    }
}