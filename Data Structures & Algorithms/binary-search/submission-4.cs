public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while(l <= r) {
            int midpoint = l + (r - l) / 2;

            if(nums[midpoint] == target) {
                return midpoint;
            }
            else if (nums[midpoint] < target) {
                l = midpoint + 1;
            }
            else {
                r = midpoint - 1;
            }
        }

        return -1;
    }
}
