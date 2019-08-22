class Solution(object):
    def firstUniqChar(self, s):
        """
        :type s: str
        :rtype: int
        """
        counts = {}
        for char in s:
            if char not in counts:
                counts[char] = 0
            counts[char] += 1
        i = 0
        while i < len(s):
            if counts[s[i]] == 1:
                return i
            i += 1
        return -1