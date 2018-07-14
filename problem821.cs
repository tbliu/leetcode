public class Solution {
    public int[] ShortestToChar(string S, char C) {
        Dictionary<char, List<int>> charToIndex = new Dictionary<char, List<int>>();
        for (int i = 0; i < S.Length; i++) {
            char c = S[i];
            if (!charToIndex.ContainsKey(c)) {
                charToIndex[c] = new List<int>();
            }
            charToIndex[c].Add(i);
        }

        int[] dists = new int[S.Length];
        for (int i = 0; i < S.Length; i++) {
            dists[i] = GetShortestDistance(i, C, charToIndex);
        }
        return dists;
    }

    private int GetShortestDistance(int start, char target, Dictionary<char, List<int>> mappings) {
        int min = Int32.MaxValue;
        List<int> indices = mappings[target];
        foreach (int index in indices) {
            int dist = Math.Abs(start - index);
            if (dist < min) {
                min = dist;
            }
        }
        return min;
    }
}