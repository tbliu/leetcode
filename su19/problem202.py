class Solution(object):
    def isHappy(self, n):
        """
        :type n: int
        :rtype: bool
        """
        seen = set()
        while True:
            seen.add(n)
            n = self.sumSquaredDigits(n)
            if n == 1:
                return True
            if n in seen:
                return False

    def sumSquaredDigits(self, n):
        sum = 0
        while n > 0:
            digit = n % 10
            sum += digit ** 2
            n /= 10
        return sum