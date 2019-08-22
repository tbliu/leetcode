class Solution(object):
    def moveZeroes(self, nums):
        """
        :type nums: List[int]
        :rtype: None Do not return anything, modify nums in-place instead.
        """
        nextZero = len(nums)
        i = 0
        while i < len(nums):
            if nums[i] != 0 and i > nextZero:
                nums[nextZero] = nums[i]
                nums[i] = 0
                i, nextZero = nextZero, i
            elif nums[i] == 0 and i < nextZero:
                nextZero = i
                i += 1
            else:
                i += 1

        return
            
        