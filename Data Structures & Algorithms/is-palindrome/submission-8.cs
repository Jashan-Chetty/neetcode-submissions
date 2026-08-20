public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> check = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];

            if(check.ContainsKey(diff))
                return new int[] { check[diff] , i };

            check[nums[i]] = i;
        }

        return null;
    }
}
