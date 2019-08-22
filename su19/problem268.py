class Solution(object):
    def missingNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        actual = nums[0]
        expected = 0
        for i in range(1, len(nums)):
            actual ^= nums[i]
            expected ^= i
        expected ^= len(nums)
        missing = actual ^ expected
        return missing