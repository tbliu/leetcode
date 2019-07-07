public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> nums = new List<int>();
        for (int i = left; i <= right; i++) {
            if (IsSelfDividing(i)) {
                nums.Add(i);
            }
        }
        return nums;
    }

    private bool IsSelfDividing(int n) {
        int copy = n;
        while (n != 0) {
            int div = n % 10;
            if (div == 0 || copy % div != 0) {
                return false;
            }
            n /= 10;
        }
        return true;
    }
}