public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;

        int[] alf = new int[26];

        for(int i = 0; i < s.Length; i++) {
            alf[s[i] - 'a']++;
            alf[t[i] - 'a']--;
        }

        foreach(int i in alf) {
            if(i != 0) {
                return false;
            }
        }

        return true;
    }
}
