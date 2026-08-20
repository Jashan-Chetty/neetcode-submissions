public class Solution {
    public bool hasDuplicate(int[] nums) {
        const total = nums.Length;
        HashSet<int> isDup = new HashSet<int>(nums);

        const totalHash = isDup.AsEnumerable.Count();

        if (total != totalHash)
            return true;
        else
            return false;
    }
}