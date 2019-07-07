public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        IList<int> smaller = new List<int>();
        IList<int> middle = new List<int>();
        IList<int> larger = new List<int>();
        Random rand = new Random();
        int pivot = rand.Next(0, nums.Length);
        var start = nums[pivot];
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] == start) {
                middle.Add(nums[i]);
            } else if (nums[i] > start) {
                larger.Add(nums[i]);
            } else {
                smaller.Add(nums[i]);
            }
        }

        if (k <= larger.Count()) {
            return FindKthLargest(larger.ToArray(), k);
        } else if (k - larger.Count() <= middle.Count()) {
            return start;
        } else {
            return FindKthLargest(smaller.ToArray(), k - larger.Count() - middle.Count());
        }
    }
}