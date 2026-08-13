public class Solution {
    public bool hasDuplicate(int[] nums) {
        int totalNums = nums.Length;

        HashSet<int> IsDup = new HashSet<int>(nums);

        int total = IsDup.Count();
        if(total.Equals(totalNums))
            return false;

        return true;

    }
}