public class Solution {
    public bool IsValid(string s) {
        int l = 0;
        int r = s.Length - 1;
        while(l < r) {
            if(s[l].Equals(s[r]))
            {
               l++;
               r--;
            }

            return true;
        }

        return false;
    }
}
