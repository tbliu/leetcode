class Solution(object):
    def intersect(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: List[int]
        """
        if len(nums1) < len(nums2):
            smaller = nums1
            larger = nums2
        else:
            smaller = nums2
            larger = nums1
        counts = {}
        for elem in smaller:
            if elem not in counts:
                counts[elem] = 0
            counts[elem] += 1
        intersection = []
        for elem in larger:
            if elem in counts and counts[elem] > 0:
                intersection.append(elem)
                counts[elem] -= 1
        return intersection