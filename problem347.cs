public class Solution {
    /* Solution runs in O(n) + O(k log k) time */
    public IList<int> TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        IList<int> topKFrequent = new List<int>();
        foreach (var num in nums) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts.Add(num, 1);
            }
        }

        var sortedCounts = counts
            .OrderBy(kvp => -1 * kvp.Value)
            .Select(kvp => kvp.Key)
            .ToList();
            
        for (var i = 0; i < k; i++) {
            topKFrequent.Add(sortedCounts[i]);
        }
        return topKFrequent;
    }
}