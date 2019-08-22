class Solution(object):
    def subsets(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        if not nums:
            return [[]]
        sol = []
        nums.sort()
        self.backtrack(sol, [], nums, 0)
        return sol

    def backtrack(self, sol, tempList, nums, start):
        sol.append(tempList[:])
        for i in range(start, len(nums)):
            if nums[i] in tempList:
                continue
            tempList.append(nums[i])
            self.backtrack(sol, tempList, nums, start + 1)
            tempList.pop()