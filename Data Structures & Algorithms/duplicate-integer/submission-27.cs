public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();

        foreach(int num in nums) {
            if(seen.Contains(nums)) {
                return true;
            }
        }
        return false;
    }
}