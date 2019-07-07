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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int start, int end) {
        if (start > end) {
            return null;
        }
        var maxIndex = GetIndexOfMax(nums, start, end);
        TreeNode node = new TreeNode(nums[maxIndex]);
        node.left = Helper(nums, start, maxIndex - 1);
        node.right = Helper(nums, maxIndex + 1, end);
        return node;
    }

    private int GetIndexOfMax(int[] nums, int start, int end) {
        var max = nums[start];
        var index = start;
        for (var i = start + 1; i <= end; i++) {
            if (nums[i] > max) {
                max = nums[i];
                index = i;
            }
        }
        return index;
    }
}