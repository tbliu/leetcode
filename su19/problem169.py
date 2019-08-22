class Solution(object):
    def majorityElement(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        currLargest = nums[0]
        count = 1
        i = 1
        while i < len(nums):
            if nums[i] == currLargest:
                count += 1
            elif count > 0:
                count -= 1
            else:
                currLargest = nums[i]
                count = 1
            i += 1
        return currLargest

        