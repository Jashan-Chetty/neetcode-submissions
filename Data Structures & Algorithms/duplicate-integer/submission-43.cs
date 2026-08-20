public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> isDup = new HashSet<int>(nums);

        // Count Checks total items
        if(isDup.Count() != nums.Length)
            return true; // there was a duplicate

        return false;
    }
}