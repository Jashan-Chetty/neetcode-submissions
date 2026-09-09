public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right) {
            int midpoint = left + (right - left) / 2;

            if(nums[midpoint] == target) {
                return midpoint;
            } 
            else if(nums[midpoint] < target) {
                left = midpoint + 1;
            }
            else {
                right = midpoint - 1;
            }
        }

        return -1;
    }
}
