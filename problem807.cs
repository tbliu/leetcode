public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        var maxRowValues = MaxRowValues(grid);
        var maxColValues = MaxColValues(grid);

        var sum = 0;
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[i].Length; j++) {
                sum += Math.Min(maxRowValues[i], maxColValues[j]) - grid[i][j];
            }
        }
        return sum;
    }

    private IList<int> MaxRowValues(int[][] grid) {
        IList<int> maxValues = new List<int>();
        foreach (var row in grid) {
            maxValues.Add(row.Max());
        }
        return maxValues;
    }

    private IList<int> MaxColValues(int[][] grid) {
        IList<int> maxColValues = new List<int>();
        int[] firstRow = grid[0];
        foreach (var num in firstRow) {
            maxColValues.Add(num);
        }

        for (var i = 1; i < grid.Length; i++) {
            int[] row = grid[i];
            for (var j = 0; j < row.Length; j++) {
                if (row[j] > maxColValues[j]) {
                    maxColValues[j] = row[j];
                }
            }
        }
        return maxColValues;
    }
}