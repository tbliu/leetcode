public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        int curr = nums[0];
        int insertIdx = 1;
        int uniqueCount = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != curr) {
                nums[insertIdx] = nums[i];
                insertIdx++;
                uniqueCount++;
                curr = nums[i];
            }
        }
        return uniqueCount;
    }
}