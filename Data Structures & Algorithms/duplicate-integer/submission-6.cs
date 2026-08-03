public class Solution {
    public bool hasDuplicate(int[] nums) {

        Array.Sort(nums);

        // 3, 7, 8, 9, 10
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] == nums[i - 1]) {
                return true;
            }
        }
        return false;
    }
}