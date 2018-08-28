public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach (int num in nums) {
            set.Add(num);
        }

        int i;
        for (i = 0; i <= nums.Length; i++) {
            if (!set.Contains(i)) {
                return i;
            }
        }
        return i;
    }
}