public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int i = 0;
        int j = 0;
        int minLen = int.MaxValue;
        int sum = 0;

        while (i < nums.Length) {
            sum += nums[i];
            i++;

            while (sum >= s) {
                if (i - j < minLen) {
                    minLen = i - j;
                }
                sum -= nums[j];
                j++;
            }
        }
        return (minLen == int.MaxValue) ? 0 : minLen;
    }
}