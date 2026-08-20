public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new();
        string open = "({[";
        string close = ")}]";
        
        for (int i = 0; i < s.Length; i++) {
            char current = s[i];

            if (open.Contains(s[i])) {
                st.Push(s[i]);
            } else {
                if (st.TryPop(out char pop)) {
                    if (close.IndexOf(current) != open.IndexOf(pop)) {
                        return false;
                    }
                } else {
                    return false;
                }
                
            }
        }

        if (st.Count > 0) return false;
        return true;
    }
}
