public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        // HashSet can only have unqiue elements to it
        HashSet<int> check = new HashSet<int>();

        foreach(int num in nums) {
            if(check.Contains(num)) {
                return true;
            }

            check.Add(num);
        }

        return false;
    }
}