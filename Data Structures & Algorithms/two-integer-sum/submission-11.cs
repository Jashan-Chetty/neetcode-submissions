public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new();

        for(int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i]; // difference we need to find in the hashmap

            if(seen.ContainsKey(difference)) {
                return new int[] { seen[difference], i };
            }

            seen[nums[i]] = i;
        }

        return null;
    } 
}
