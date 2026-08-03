public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        } 

        Dictionary<char, int> cS = new Dictionary<char, int>();  
        Dictionary<char, int> cT = new Dictionary<char, int>(); 

        for(int i = 0; i < s.Length; i++) {
            cS[s[i]] = cS.GetValueOrDefault(s[i], 0) + 1;
            cT[t[i]] = cT.GetValueOrDefault(t[i], 0) + 1;
        } 

        return !cS.Except(cT).Any();
    }
}