class Solution(object):
    def numIslands(self, grid):
        """
        :type grid: List[List[str]]
        :rtype: int
        """
        count = 0
        for i in range(len(grid)):
            for j in range(len(grid[i])):
                if grid[i][j] == '1':
                    self.sink(grid, i, j)
                    count += 1
        return count

    def sink(self, grid, i, j):
        if i >= len(grid) or i < 0 or j >= len(grid[i]) or j < 0:
            return
        if grid[i][j] == '1':
            grid[i][j] = '0'
            self.sink(grid, i-1, j)
            self.sink(grid, i+1, j)
            self.sink(grid, i, j-1)
            self.sink(grid, i, j+1)
        