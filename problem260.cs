public class Solution {
    public int[] SingleNumber(int[] nums) {
        // XOR all the numbers together. Since there are at least 2 distinct
        // values in the array. There is at least one set bit in the final value.
        var diff = 0;
        foreach (var num in nums) {
            diff ^= num;
        }

        // Get an arbitrary set bit from the XOR'd number
        diff &= -diff;
        int[] ret = new int[] {0, 0};
        foreach (var num in nums) {
            if ((diff & num) == 0) {
                ret[0] ^= num;
            } else {
                ret[1] ^= num;
            }
        }
        return ret;
    }
}