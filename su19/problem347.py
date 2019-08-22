class Solution(object):
    def topKFrequent(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: List[int]
        """
        # Populate freq: O(n), iterate through freq: O(n) -> total: O(n)
        # key: number, val: number of times it has been seen
        seen = {} 
        # val: frequency: val: list of values that occurred at least that many times
        freq = {} 

        # populate freq with values
        for num in nums:
            if num not in seen:
                seen[num] = 0
            seen[num] += 1

            if seen[num] not in freq:
                freq[seen[num]] = []
            freq[seen[num]].append(num)

        # iterate through freq
        i = len(nums)
        topK = set()
        while len(topK) != k and i >= 0:
            if i in freq:
                for num in freq[i]:
                    topK.add(num)
            i -= 1
        return list(topK)
        
        