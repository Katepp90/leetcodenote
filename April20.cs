
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

// Update the method to save space

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length < 1) return 0;
        int target = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[target] != nums[i] && (i-target) > 1) nums[++target] = nums[i];
            if(nums[target] != nums[i] && (i-target) <= 1) target ++;
        }
        return target+1;
    }
}
