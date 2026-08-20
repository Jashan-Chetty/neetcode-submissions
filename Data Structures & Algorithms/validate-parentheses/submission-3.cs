public class Solution {
    public bool IsValid(string s) {
        Stack<char> expected = new Stack<char>(s.Length / 2);

        foreach (char c in s) {
            if (c == '(') {
                expected.Push(')');
            } else if (c == '{') {
                expected.Push('}');
            } else if (c == '[') {
                expected.Push(']');
            } else {
                if (expected.Count == 0 || expected.Pop() != c) {
                    return false;
                }
            }
        }

        return expected.Count == 0;
    }
}
