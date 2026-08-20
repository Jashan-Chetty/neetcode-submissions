public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 1; i < num.Length; i++) {
            for (int j = i - 1; j < num.Length; i++) {
                if(nums[i] + nums[j] == target) {
                    return nums[i, j];
                }
            }
        }
    }
}
