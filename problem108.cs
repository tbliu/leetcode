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
    public TreeNode SortedArrayToBST(int[] nums) {
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int start, int stop) {
        if (start > stop) {
            return null;
        }
        int medianIndex = (start + stop) / 2;
        TreeNode node = new TreeNode(nums[medianIndex]);
        node.left = Helper(nums, start, medianIndex - 1);
        node.right = Helper(nums, medianIndex + 1, stop);
        return node;
    }
}