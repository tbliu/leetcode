public class Solution {
    public bool IsBipartite(int[][] graph) {
        HashSet<int> s1 = new HashSet<int>();
        HashSet<int> s2 = new HashSet<int>();
        bool bipartite = Search(graph, s1, s2, 0);
        for (int node = 0; node < graph.Length; node++) {
            if (!s1.Contains(node) && !s2.Contains(node)) {
                bipartite = bipartite && Search(graph, s1, s2, node);
            }
        }
        return bipartite;
    }

    private bool Search(int[][] graph, HashSet<int> s1, HashSet<int> s2, int currNode) {
        if (currNode >= graph.Length || s1.Contains(currNode) || s2.Contains(currNode)) {
            return true;
        }
        int[] neighbors = graph[currNode];
        if (neighbors.Length == 0) {
            return Search(graph, s1, s2, currNode + 1);
        }
        s1.Add(currNode);
        bool bipartite = true;
        foreach (int neighbor in neighbors) {
            if (s1.Contains(neighbor)) {
                return false;
            }
            if (s2.Contains(neighbor)) {
                continue;
            }
            bipartite = bipartite && Search(graph, s2, s1, neighbor);
            if (!bipartite) {
                return bipartite;
            }
        }
        return bipartite;
    }
}