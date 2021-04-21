public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length == 0 ) return 0;
        int j = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(i == 0 || nums[i] > nums[j-1]) {nums[j] = nums[i]; j++;}
        }
        return j;
    }
}