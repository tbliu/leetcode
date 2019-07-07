public class Solution {
    public int MajorityElement(int[] nums) {
        int major = nums[0];
        int count = 0;
        foreach (int num in nums) {
            if (count == 0) {
                major = num;
                count = 1;
            } else if (num == major) {
                count++;
            } else {
                count--;
            }
        }
        return major;
    }
}