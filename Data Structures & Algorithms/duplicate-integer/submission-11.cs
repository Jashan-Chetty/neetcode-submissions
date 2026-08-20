public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> checked = new HashSet<int>;

        foreach(num in nums) {
            if(checked.Contains(num)) {
                return true;
            }
            checked.Add(num);
        }
        return false;
    }
}