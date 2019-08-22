class Solution(object):
    def singleNumber(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        i = 1
        sol = nums[0]
        while i < len(nums):
            sol = sol ^ nums[i]
            i += 1
        return sol
        