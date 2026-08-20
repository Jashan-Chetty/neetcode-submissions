public class Solution {
    public bool hasDuplicate(int[] nums) {
        return HashSet<int> check = new HashSet<int>(nums).Count() < nums.Length;
    }
}