public class Solution {
    public void MoveZeroes(int[] nums) {
        var count = 0;
        for (var i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                var temp = nums[i];
                nums[i] = 0;
                nums[count] = temp;
                count++;
            }
        }
    }
}