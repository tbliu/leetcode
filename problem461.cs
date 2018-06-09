public class Solution {
    public int HammingDistance(int x, int y) {
        // XOR will have 1's in every bit that is different
        // so we need to XOR x and y together to get the bits that are different.
        // Then we have to apply a mask to find the number of set bits.

        int diff = x ^ y;
        return countSetBits(diff);        
    }

    private int countSetBits(int x) {
        int count = 0;
        while (x != 0) {
            x &= x - 1;
            count++;
        }
        return count;
    }
}