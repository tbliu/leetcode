public class Solution {
    public int MaxProduct(string[] words) {
        IList<HashSet<char>> allLetters = new List<HashSet<char>>();
        foreach (var word in words) {
            HashSet<char> letters = new HashSet<char>();
            foreach (var letter in word) {
                letters.Add(letter);
            }
            allLetters.Add(letters);
        }

        var max = 0;
        for (var i = 0; i < words.Length; i++) {
            for (var j = i + 1; j < words.Length; j++) {
                var length = words[i].Length * words[j].Length;
                if (length > max && Valid(words[i], allLetters[j])) {
                    max = length;
                }
            }
        }
        return max;
    }

    private bool Valid(string s1, HashSet<char> letters) {
        foreach (var c in s1) {
            if (letters.Contains(c)) {
                return false;
            }
        }
        return true;
    }
}