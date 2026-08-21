public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> isDup = new HashSet<int>(nums);

        return(isDup.Count != nums.Length);
    }
}