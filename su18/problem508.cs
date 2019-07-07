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
    public int[] FindFrequentTreeSum(TreeNode root) {
        Dictionary<int, int> sumCounts = new Dictionary<int, int>();
        SumAtNode(root, sumCounts);
        var max = -1;
        var count = 0;
        foreach (var kvp in sumCounts) {
            if (kvp.Value > max) {
                max = kvp.Value;
                count = 0;
            }
            if (kvp.Value == max) {
                count++;
            }
        }
        int[] frequent = new int[count];
        var i = 0;
        foreach (var kvp in sumCounts) {
            if (kvp.Value == max) {
                frequent[i] = kvp.Key;
                i++;
            }
        }
        return frequent;
    }

    private int SumAtNode(TreeNode node, Dictionary<int, int> sumCounts) {
        if (node == null) {
            return 0;
        } else if (node.left == null && node.right == null) {
            AddOrDefault(sumCounts, node.val);
            return node.val;
        } else {
            var leftSum = SumAtNode(node.left, sumCounts);
            var rightSum = SumAtNode(node.right, sumCounts);
            var sum = leftSum + rightSum + node.val;
            AddOrDefault(sumCounts, sum);
            return sum;
        }
    }

    private void AddOrDefault(Dictionary<int, int> sumCounts, int val) {
        if (sumCounts.ContainsKey(val)) {
            sumCounts[val]++;
        } else {
            sumCounts.Add(val, 1);
        }
    }
}