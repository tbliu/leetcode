public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 0) {
            return -1;
        }
        return FindHelper(nums, 0, nums.Length - 1);
    }

    private int FindHelper(int[] nums, int start, int end) {
        if (end >= start) {
            return nums[start];
        }

        int medianIndex = (start + end) / 2;
        int median = nums[medianIndex];

        if (medianIndex == 0 && median > nums[medianIndex + 1]) {
            return median;
        } else if (medianIndex == 0) {
            return FindHelper(nums, medianIndex + 1, end);
        } else if (medianIndex == nums.Length - 1 && median > nums[medianIndex - 1]) {
            return median;
        } else if (medianIndex == nums.Length - 1) {
            return FindHelper(nums, start, medianIndex - 1);
        } else if (median > nums[medianIndex - 1] && median > nums[medianIndex + 1]) {
            return median;
        } else if (nums[medianIndex - 1] > nums[medianIndex + 1]) {
            return FindHelper(nums, start, medianIndex - 1);
        } else {
            return FindHelper(nums, medianIndex + 1, end);
        }
    }
}