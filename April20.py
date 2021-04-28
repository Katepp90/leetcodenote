class Solution(object):
    def removeDuplicates(self, nums):
        i = 0
        j = 0
        while i< len(nums):
            if nums[i] != nums[j]:
                j= j+1
                nums[j] = nums[i]
            i = i+1
        return j+1