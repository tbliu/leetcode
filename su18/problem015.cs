public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> sol = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 1; i++) {
            if (i > 0 && nums[i] == nums[i-1]) {
                continue;
            }
            int curr = nums[i];
            int low = i + 1;
            int high = nums.Length - 1;
            while (low < high) {
                if (nums[low] + nums[high] + curr == 0) {
                    IList<int> triple = new List<int>();
                    triple.Add(nums[low]); triple.Add(nums[high]); triple.Add(curr);
                    sol.Add(triple);
                    while (low < high && nums[low] == nums[low+1]) low++;
                    while (low < high && nums[high] == nums[high-1]) high--;
                    low++; high--;
                } else if (nums[low] + nums[high] + curr < 0) {
                    low++;
                } else {
                    high--;
                }

            }
        }
        return sol;
    }
}