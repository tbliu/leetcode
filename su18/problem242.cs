public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        foreach (char letter in s) {
            if (!counts.ContainsKey(letter)) {
                counts.Add(letter, 0);
            }
            counts[letter]++;
        }

        foreach (char letter in t) {
            if (!counts.ContainsKey(letter)) {
                return false;
            }
            counts[letter]--;
        }

        foreach (var kvp in counts) {
            if (kvp.Value != 0) {
                return false;
            }
        }

        return true;
    }
}