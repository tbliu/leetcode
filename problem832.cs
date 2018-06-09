public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        foreach (int[] row in A) {
            int start = 0;
            int end = row.Length - 1;
            while (start <= end) {
                int temp = row[start];
                row[start] = 1 - row[end];
                row[end] = 1 - temp;
                start++; 
                end--;
            }
        }
        return A;
    }
}