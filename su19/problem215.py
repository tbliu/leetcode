class Solution(object):
    def findKthLargest(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        import random
        pivot = nums[random.randint(0, len(nums)-1)]
        less = []
        eq = [] 
        greater = []
        for num in nums:
            if num < pivot:
                less.append(num)
            elif num == pivot:
                eq.append(num)
            else:
                greater.append(num)
        if k <= len(greater):
            return self.findKthLargest(greater, k)
        elif k > len(greater) + len(eq):
            return self.findKthLargest(less, k - len(greater) - len(eq))
        else:
            return pivot