public class Solution {
    public int FirstUniqChar(string s) {
        int[] counts = new int[26];
        foreach (char letter in s) {
            counts[letter - 'a']++;
        }

        for (int i = 0; i < s.Length; i++) {
            if (counts[s[i] - 'a'] == 1) {
                return i;
            }
        }
        return -1;
    }
}