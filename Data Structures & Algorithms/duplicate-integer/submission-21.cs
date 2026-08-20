public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);

        int[] noDup = [];

        for(int i = 0; i < nums.length; i++) {
            if(nums[i] == nums[i + 1]) {
                nums[i] = noDup[i];
            }
            nums[i] = noDup[i];
        }
    }
}