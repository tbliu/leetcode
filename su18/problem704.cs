public class Solution {
    public int Search(int[] nums, int target) {
        return SearchHelper(nums, target, 0, nums.Length - 1);
    }

    private int SearchHelper(int[] nums, int target, int start, int stop) {
        int median = (start + stop) / 2;
        if (start > stop) {
            return -1;
        } else if (target == nums[median]) {
            return median;
        } else if (target > nums[median]) {
            return SearchHelper(nums, target, median + 1, stop);
        } else { // if (target < nums[median])
            return SearchHelper(nums, target, start, median - 1);
        }
    }
}