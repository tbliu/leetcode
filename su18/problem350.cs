public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> count1 = new Dictionary<int, int>();
        Dictionary<int, int> count2 = new Dictionary<int, int>();

        foreach (int num in nums1) {
            if (!count1.ContainsKey(num)) {
                count1.Add(num, 0);
            }
            count1[num]++;
        }

        foreach (int num in nums2) {
            if (!count2.ContainsKey(num)) {
                count2.Add(num, 0);
            }
            count2[num]++;
        }

        IList<int> intersection = new List<int>();
        foreach (var kvp in count1) {
            if (count2.ContainsKey(kvp.Key)) {
                int count = (count1[kvp.Key] > count2[kvp.Key])
                    ? count2[kvp.Key]
                    : count1[kvp.Key];
                for (int j = 0; j < count; j++) {
                    intersection.Add(kvp.Key);
                }
            }
        }
        return intersection.ToArray();
    }
}