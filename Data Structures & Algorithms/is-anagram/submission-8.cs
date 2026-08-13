public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        Dictionary<char, int> sValue = new Dictionary<char, int>();
        Dictionary<char, int> tValue = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++) {
            sValue[s[i]] = sValue.GetValueOrDefault(s[i], 0) + 1;
            tValue[t[i]] = tValue.GetValueOrDefault(t[i], 0) + 1;
        }

        return sValue.Count == tValue.Count && !sValue.Except(tValue).Any();
    }
}
