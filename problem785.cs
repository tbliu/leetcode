public class Solution {
    public bool IsBipartite(int[][] graph) {
        // Colors will be 0 and 1. Uncolored nodes will be -1
        int[] colors = new int[graph.Length];
        for (int i = 0; i < colors.Length; i++) {
            colors[i] = -1;
        }
        for (int node = 0; node < graph.Length; node++) {
            if (colors[node] == -1) { // New connected component
                colors[node] = 0;
                if (!Search(graph, colors, node)) {
                    return false;
                }
            }
        }
        return true;
    }

    private bool Search(int[][] graph, int[] colors, int currNode) {
        int[] neighbors = graph[currNode];
        int color = colors[currNode];
        foreach (int neighbor in neighbors) {
            if (colors[neighbor] == color) {
                return false;
            }

            if (colors[neighbor] == -1) {
                colors[neighbor] = 1 - color;
                if (!Search(graph, colors, neighbor)) {
                    return false;
                }
            }
        }
        return true;
    }
}