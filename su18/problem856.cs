public class Solution {
    public int ScoreOfParentheses(string S) {
        var numOpen = 0;
        var nested = false;
        var score = 0;
        for (var i = 0; i < S.Length; i++) {
            if (S[i] == '(') {
                nested = true;
                numOpen += 1;
            }

            if (S[i] == ')') {
                numOpen -= 1;
                if (nested && numOpen > 0) {
                    score += (int) Math.Pow(2, numOpen);
                    nested = false;
                } else if (nested && numOpen == 0) {
                    score += 1;
                }
            }
        }
        return score;
    }
}