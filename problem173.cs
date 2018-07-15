/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class BSTIterator {
    Stack<TreeNode> nodes;
    public BSTIterator(TreeNode root) {
        this.nodes = new Stack<TreeNode>();
        TreeNode node = root;
        while (node != null) {
            this.nodes.Push(node);
            node = node.left;
        }
    }

    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return this.nodes.Count() > 0;
    }

    /** @return the next smallest number */
    public int Next() {
        TreeNode node = this.nodes.Pop();
        var ret = node.val;
        node = node.right;
        while (node != null) {
            this.nodes.Push(node);
            node = node.left;
        }
        return ret;
    }
}

/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */