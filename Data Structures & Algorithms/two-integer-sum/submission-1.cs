public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; i < nums.Length - 1; j++) {
                if(nums[i] + nums[j] == target && nums[i] != nums[j]) {
                    return new int[]{i, j}; 
                }
            }
        }
        return new int[0]; 
    }
}
