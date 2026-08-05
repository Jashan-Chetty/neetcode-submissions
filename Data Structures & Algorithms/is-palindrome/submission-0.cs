public class Solution {
    public bool IsPalindrome(string s) {
        // string nospace = s.Replace(" ", string.Empty);
        // string nospace = new string(s.Where(c => char.IsLetterOrDigit(c) || c == ' ').ToArray());

        StringBuilder sb = new StringBuilder();

        foreach(char c in s) {
            if(char.IsLetterOrDigit(c)){
                sb.Append(c);
            }
        }

        string nospace = sb.ToString().ToLower();

        char[] revArr = nospace.ToCharArray();
        Array.Reverse(revArr);
        string reverse = new string(revArr).ToLower();

        if(nospace.Equals(reverse))
            return true;
        else
            return false;
    }
}
