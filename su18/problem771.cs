public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var jewels = new HashSet<Char>();
        foreach (var c in J) {
            jewels.Add(c);
        }
        var count = 0;
        foreach (var c in S) {
            if (jewels.Contains(c)) {
                count++;
            }
        }
        return count;
    }
}