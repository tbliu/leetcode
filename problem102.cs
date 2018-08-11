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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> order = new List<IList<int>>();
        if (root == null) {
            return order;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int numCurrLevel = 1;
        int numNextLevel = 0;
        while (queue.Count() > 0) {
            IList<int> level = new List<int>();
            while (numCurrLevel > 0) {
                TreeNode node = queue.Dequeue();
                numCurrLevel--;
                level.Add(node.val);
                if (node.left != null) {
                    numNextLevel++;
                    queue.Enqueue(node.left);
                }
                if (node.right != null) {
                    numNextLevel++;
                    queue.Enqueue(node.right);
                }
            }
            order.Add(level);
            numCurrLevel = numNextLevel;
            numNextLevel = 0;
        }
        return order;
    }
}