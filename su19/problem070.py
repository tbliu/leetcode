class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        cache = [0] * (n + 1)
        cache[0] = 1
        cache[1] = 1
        i = 2
        while i < n + 1:
            cache[i] = cache[i - 1] + cache[i - 2]
            i += 1
        return cache[n]