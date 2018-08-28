public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (n == 0) {
            return;
        }
        int i = 0;
        int j = 0;
        while (i < m) {
            if (nums1[i] <= nums2[j]) {
                i++;
            } else {
                int temp = nums1[i];
                nums1[i] = nums2[j];
                nums2[j] = temp;
                Array.Sort(nums2);
            }
        }

        while (j < n) {
            nums1[i] = nums2[j];
            i++;
            j++;
        }
        return;
    }
}