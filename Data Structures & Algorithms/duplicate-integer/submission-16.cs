public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>(nums);
        return check.Count() < nums.Length;
    }
}