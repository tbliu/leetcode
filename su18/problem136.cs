public class Solution {
    public int SingleNumber(int[] nums) {
        var num = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            num ^= nums[i];
        }
        return num;
    }
}