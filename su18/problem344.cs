public class Solution {
    public string ReverseString(string s) {
        StringBuilder reversed = new StringBuilder();
        for (var i = s.Length - 1; i >= 0; i--) {
            reversed.Append(s[i]);
        }
        return reversed.ToString();
    }
}