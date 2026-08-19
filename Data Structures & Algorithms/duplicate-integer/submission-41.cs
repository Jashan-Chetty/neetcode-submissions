public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> isDup = new HashSet<int>(nums);

        if(isDup.Count() != nums.Length)
            return true;
        return false;
    }
}