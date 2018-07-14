public class Solution {
    public int HammingWeight(uint n) {
        var weight = 0;
        while (n > 0) {
            if (n % 2 != 0) {
                weight++;
            }
            n /= 2;
        }
        return weight;
    }
}