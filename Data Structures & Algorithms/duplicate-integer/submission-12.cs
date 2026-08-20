public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> check = new HashSet<int>();

        foreach(num in nums) {
            if(check.Contains(num)) {
                return true;
            }
            check.Add(num);
        }
        return false;
    }
}