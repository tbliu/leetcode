class Solution(object):
    def titleToNumber(self, s):
        """
        :type s: str
        :rtype: int
        """
        col = 0
        multiplier = 1
        i = len(s) - 1
        while i >= 0:
            rank = ord(s[i].lower()) - 96
            col += rank * multiplier
            multiplier *= 26
            i -= 1
        return col