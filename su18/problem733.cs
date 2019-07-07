public class Solution {
    public int[,] FloodFill(int[,] image, int sr, int sc, int newColor) {
        var oldColor = image[sr, sc];
        if (oldColor == newColor) {
            return image;
        }
        DFS(image, sr, sc, newColor, oldColor);
        return image;
    }
    
    private void DFS(int[,] image, int sr, int sc, int newColor, int oldColor) {
        if (sr < 0 || sc < 0 || sr >= image.GetLength(0) || sc >=  image.GetLength(1)) {
            return;
        }
        
        if (image[sr, sc] != oldColor) {
            return;
        }
    
        image[sr, sc] = newColor;
        DFS(image, sr + 1, sc, newColor, oldColor);
        DFS(image, sr - 1, sc, newColor, oldColor);
        DFS(image, sr, sc + 1, newColor, oldColor);
        DFS(image, sr, sc - 1, newColor, oldColor);
    }
}