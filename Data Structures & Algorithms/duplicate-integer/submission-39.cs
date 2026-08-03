public class Solution {
    public bool hasDuplicate(int[] nums) {
        int total = nums.Length;
        HashSet<int> isDup = new HashSet<int>(nums);

        int totalHash = isDup.Count;

        if (total != totalHash)
            return true;
        else
            return false;
    }
}