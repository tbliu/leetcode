class Solution(object):
    def generate(self, numRows):
        """
        :type numRows: int
        :rtype: List[List[int]]
        """
        lst = []
        prev = None
        for _ in range(numRows):
            row = self.getRow(prev)
            lst.append(row)
            prev = row
        return lst
    
    def getRow(self, prevRow):
        row = [1]
        if prevRow is None:
            return row
        for i in range(len(prevRow) - 1):
            row.append(prevRow[i] + prevRow[i + 1])
        row.append(1)
        return row