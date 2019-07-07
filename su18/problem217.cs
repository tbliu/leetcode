public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> contains = new HashSet<int>();
        foreach (var num in nums) {
            if (contains.Contains(num)) {
                return true;
            }
            contains.Add(num);
        }
        return false;
    }
}