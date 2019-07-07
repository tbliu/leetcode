public class Solution {
    public int TitleToNumber(string s) {
        // To convert letter to integer number: char.ToUpper(c) - 64
        int col = 0;
        int multiplier = 1;
        for (int i = s.Length - 1; i >= 0; i--) {
            col += multiplier * (char.ToUpper(s[i]) - 64);
            multiplier *= 26;
        }
        return col;
    }
}