public class Solution {
    public bool IsAnagram(string s, string t) {     

        if(s.Length != t.Length) {
            return false;
        }

        char[] charactersS = s.ToCharArray();
        char[] charactersT  = t.ToCharArray();
        
        Array.Sort(charactersS);
        Array.Sort(charactersT);

        for(int i = 0; i < charactersS.Length; i++) {
            if(charactersS[i] != charactersT[i]) {
                return false;
            }
        }
        return true;
    }
}
